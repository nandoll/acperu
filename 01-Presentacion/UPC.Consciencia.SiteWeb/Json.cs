using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Text;
using System.Net;
using System.Net.Security;

namespace UPC.Consciencia.SiteWeb
{

    public class Json
    {

        private String _Usuario;
        private String _Clave;
        private String _Method;
        private String _ContentType;
        private String _Accept;
        private String _Cookie;
        private String _SoapAction;

        public String Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }

        public String Clave
        {
            get { return _Clave; }
            set { _Clave = value; }
        }

        public String Method
        {
            get { return _Method; }
            set { _Method = value; }
        }

        public String ContentType
        {
            get { return _ContentType; }
            set { _ContentType = value; }
        }

        public String Accept
        {
            get { return _Accept; }
            set { _Accept = value; }
        }

        public String Cookie
        {
            get { return _Cookie; }
            set { _Cookie = value; }
        }

        public String SoapAction
        {
            get { return _SoapAction; }
            set { _SoapAction = value; }
        }

        public String Post(String strUrl, StringBuilder sbXml)
        {

            ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback
                                    (
                                       delegate { return true; }
                                    );

            String strRetorno = String.Empty;
            System.Net.WebClient wcService = new System.Net.WebClient();

            try
            {

                if (_Usuario != String.Empty && _Clave != String.Empty)
                {
                    wcService.Credentials = new System.Net.NetworkCredential(_Usuario, _Clave);
                    wcService.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(_Usuario + ":" + _Clave)));
                }

                wcService.Headers.Add("Method", _Method);
                wcService.Headers.Add("Content-Type", _ContentType);
                wcService.Headers.Add("Accept", _Accept);

                if (_SoapAction != String.Empty)
                {
                    wcService.Headers.Add("SOAPAction", _SoapAction);
                }

                wcService.Encoding = System.Text.Encoding.UTF8;

                if (sbXml.ToString().Trim() == String.Empty)
                {
                    strRetorno = wcService.DownloadString(strUrl);
                }
                else
                {
                    strRetorno = wcService.UploadString(strUrl, sbXml.ToString());
                }

                wcService.Dispose();
            }
            catch (Exception ex)
            {
                strRetorno = ex.Message;
                wcService.Dispose();
            }

            return strRetorno;
        }

    }

}