#pragma once

#include "IJsCacheService.h"
#include "ISchedulerService.h"
#include "IRestApiService.h"
#include "ITraceService.h"
#include "ShapeProperties.h"
#include <string>

namespace iqrf {

  class JsCache : public IJsCacheService
  {
  public:
    JsCache();
    virtual ~JsCache();

    const std::string& getDriver(int id) const override;

    void activate(const shape::Properties *props = 0);
    void deactivate();
    void modify(const shape::Properties *props);

    void attachInterface(iqrf::ISchedulerService* iface);
    void detachInterface(iqrf::ISchedulerService* iface);

    void attachInterface(shape::IRestApiService* iface);
    void detachInterface(shape::IRestApiService* iface);

    void attachInterface(shape::ITraceService* iface);
    void detachInterface(shape::ITraceService* iface);

  private:
    class Imp;
    Imp* m_imp = nullptr;
  };
}
