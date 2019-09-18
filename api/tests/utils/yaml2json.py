#!c:\python37\python.exe

# Copyright 2015 David R. Bild
#
#    Licensed under the Apache License, Version 2.0 (the "License");
#    you may not use this file except in compliance with the License.
#    You may obtain a copy of the License at
#
#        http://www.apache.org/licenses/LICENSE-2.0
#
#    Unless required by applicable law or agreed to in writing, software
#    distributed under the License is distributed on an "AS IS" BASIS,
#    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
#    See the License for the specific language governing permissions and
#    limitations under the License.

"""
Usage:
    yaml2json (--version|--help)
    yaml2json [-i <indent>] [<yaml_file>] [<json_file>]

Arguments:
    -i, --indent=INDENT  Number of spaces to indent [default: 4]
    <yaml_file>          The input file containing the YAML to convert. If not
                         specified, reads from stdin.
    <json_file>          The output file to which to write the converted JSON. If
                         not specified, writes to stdout.
"""

import sys, os
import json, yaml
import docopt

from collections import OrderedDict as odict
from yaml import MappingNode

__version__ = "1.1.1"

# Configure PyYaml to create ordered dicts
_mapping_tag = yaml.resolver.BaseResolver.DEFAULT_MAPPING_TAG

def construct_ordered_mapping(loader, node, deep=False):
    if isinstance(node, MappingNode):
        loader.flatten_mapping(node)
    return odict(loader.construct_pairs(node, deep))

def construct_yaml_ordered_map(loader, node, deep=False):
    data = odict()
    yield data
    value = construct_ordered_mapping(loader, node, deep)
    data.update(value)

yaml.add_constructor(_mapping_tag, construct_yaml_ordered_map)

# Convert from YAML to JSON
def convert(yaml_file, json_file, indent):
    loaded_yaml = yaml.load(yaml_file)
    json.dump(loaded_yaml, json_file, separators=(',',': '), indent=indent)
    json_file.write('\n')

if __name__ == '__main__':
    args = docopt.docopt(
        __doc__,
        version="version "+__version__
    )

    yaml_file = sys.stdin
    if args.get('<yaml_file>'):
        yaml_file = open(args.get('<yaml_file>'), 'r')
    with yaml_file:
        json_file = sys.stdout
        if args.get('<json_file>'):
            json_file = open(args.get('<json_file>'), 'w')
        with json_file:
            convert(yaml_file, json_file,
                    indent=int(args.get('--indent'))
            )
