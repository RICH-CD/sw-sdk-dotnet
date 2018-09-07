﻿using System;
using SW.Helpers;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SW.Services.Validate
{
    public abstract class BaseValidate : ValidateService
    {
        private string _operation;
        public BaseValidate(string url, string user, string password, string operation) : base(url, user, password)
        {
            _operation = operation;
        }
        public BaseValidate(string url, string token, string operation) : base(url, token)
        {
            _operation = operation;
        }
        public virtual ValidateXmlResponse ValidateXml(string XML)
        {
            ValidateXmlResponseHandler handler = new ValidateXmlResponseHandler();
            try
            {
                var xmlBytes = Encoding.UTF8.GetBytes(XML);
                var headers = GetHeaders();
                var content = GetMultipartContent(xmlBytes);
                return handler.GetPostResponse(this.Url,
                                string.Format("validate/cfdi33/",
                                _operation), headers, content);
            }
            catch (Exception ex)
            {
                return handler.HandleException(ex);
            }
        }
        public virtual ValidateLcoResponse ValidateLco(string Lco)
        {
            ValidateLcoResponseHandler handler = new ValidateLcoResponseHandler();
            try
            {
                var headers = GetHeaders();
                var content = RequestValidarLco(Lco);
                return handler.GetResponse(this.Url,
                                headers,
                                string.Format("lco/{0}", Lco)
                                );
            }
            catch (Exception ex)
            {
                return handler.HandleException(ex);
            }
        }

        public virtual ValidateLrfcResponse ValidateLrfc(string Lrfc)
        {
            ValidateLrfcResponseHandler handler = new ValidateLrfcResponseHandler();
            try
            {
                var headers = GetHeaders();
                var content = RequestValidarLrfc(Lrfc);
                return handler.GetResponse(this.Url,
                                headers,
                                string.Format("lrfc/{0}", Lrfc)
                                );
            }
            catch (Exception ex)
            {
                return handler.HandleException(ex);
            }
        }
    }
}
