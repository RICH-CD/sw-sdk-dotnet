﻿using SW.Services.Account;
using SW.Services.Authentication;
using SW.Services.Cancelation;
using SW.Services.Stamp;
using SW.Services.Validate;
using SW.Services.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SW.Helpers
{
    internal static class ResponseHelper
    {
        internal static AuthResponse ToAuthResponse(this Exception ex)
        {
            return new AuthResponse()
            {
                message = ex.Message,
                status = "error",
                messageDetail = ex.GetErrorDetail()
            };
        }
        internal static AccountResponse ToAccountResponse(this Exception ex)
        {
            return new AccountResponse()
            {
                message = ex.Message,
                status = "error",
                messageDetail = ex.GetErrorDetail()
            };
        }
        internal static CancelationResponse ToCancelationResponse(this Exception ex)
        {
            return new CancelationResponse()
            {
                message = ex.Message,
                status = "error",
                messageDetail = ex.GetErrorDetail()
            };
        }
        internal static StampResponseV1 ToStampResponseV1(this Exception ex)
        {
            return new StampResponseV1()
            {
                message = ex.Message,
                status = "error",
                messageDetail = ex.GetErrorDetail()
            };
        }
        internal static StampResponseV2 ToStampResponseV2(this Exception ex)
        {
            return new StampResponseV2()
            {
                message = ex.Message,
                status = "error",
                messageDetail = ex.GetErrorDetail()
            };
        }
        internal static StampResponseV3 ToStampResponseV3(this Exception ex)
        {
            return new StampResponseV3()
            {
                message = ex.Message,
                status = "error",
                messageDetail = ex.GetErrorDetail()
            };
        }
        internal static StampResponseV4 ToStampResponseV4(this Exception ex)
        {
            return new StampResponseV4()
            {
                message = ex.Message,
                status = "error",
                messageDetail = ex.GetErrorDetail()
            };
        }   
        internal static ValidateXMLResponse ToValidateXMLResponse(this Exception ex)
        {
            return new ValidateXMLResponse()
            {
                message = ex.Message,
                status = "error",
                messageDetail = ex.GetErrorDetail()
            };
        }
        internal static ValidateLcoResponse ToValidateLcoResponse(this Exception ex)
        {
            return new ValidateLcoResponse()
            {
                message = ex.Message,
                status = "error",
                messageDetail = ex.GetErrorDetail()
            };
        }
        internal static ValidateLrfcResponse ToValidateLrfcResponse(this Exception ex)
        {
            return new ValidateLrfcResponse()
            {
                message = ex.Message,
                status = "error",
                messageDetail = ex.GetErrorDetail()
            };
        }
        internal static PdfResponse ToPdfResponse(this Exception ex)
        {
            return new PdfResponse()
            {
                message = ex.Message,
                status = "error",
                messageDetail = ex.GetErrorDetail()
            };
        }

        internal static string GetErrorDetail(this Exception ex)
        {
            if (ex.InnerException != null)
                return ex.InnerException.Message;
            else
                return "";
        }
    }
}
