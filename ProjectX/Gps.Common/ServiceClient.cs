﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Gps.Common
{
    public class ServiceClient<T> : ClientBase<T> where T : class
    {
        private bool _disposed = false;
        public ServiceClient()
            : base(typeof(T).FullName)
        {
        }
        public ServiceClient(string endpointConfigurationName)
            : base(endpointConfigurationName)
        {
        }
        public T Proxy
        {
            get { return this.Channel; }
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    if (this.State == CommunicationState.Faulted)
                    {
                        base.Abort();
                    }
                    else
                    {
                        try
                        {
                            base.Close();
                        }
                        catch
                        {
                            base.Abort();
                        }
                    }
                    _disposed = true;
                }
            }
        }
    }
}
