using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;

namespace cnsWsSoap.Models
{
    public class ManagerAPC
    {

        #region "WS_APC_SS"

        public static WS_APC_SS.GetVersionResponse1 GetVersion()
        {

            var endPoint = "https://intapp0000.dcc.dbna.net/Webservice_APC_SS"; // TODO : Mover al appsettings.json

            var securityHeader = SecurityBindingElement.CreateUserNameOverTransportBindingElement();
            securityHeader.IncludeTimestamp = false;
            securityHeader.MessageSecurityVersion = MessageSecurityVersion.WSSecurity11WSTrustFebruary2005WSSecureConversationFebruary2005WSSecurityPolicy11;

            var customBinding = new CustomBinding(securityHeader, 
                new TextMessageEncodingBindingElement(MessageVersion.Soap11, Encoding.UTF8), 
                new HttpsTransportBindingElement()
                );

            using (var client = new WS_APC_SS.Webservice_APC_SSClient(customBinding, new EndpointAddress(endPoint)))
            {

                client.ClientCredentials.UserName.UserName = "h00030";
                client.ClientCredentials.UserName.Password = "Awp894Mu";

                var request = new WS_APC_SS.GetVersion()
                {
                    SolicitudVersion = new WS_APC_SS.Solicitud()
                    {
                        Usuario = "H00030",
                        Aplicacion = "PC",
                        Sucursal = 85
                    }
                };

                var response = client.GetVersionAsync(request).GetAwaiter().GetResult();

                return response;

            }
        }


        public static WS_APC_SS.Alta_SSResponse1 Alta_SS(WS_APC_SS.Alta_SS request)
        {

            var endPoint = "https://intapp0000.dcc.dbna.net/Webservice_APC_SS"; // TODO : Mover al appsettings.json

            var securityHeader = SecurityBindingElement.CreateUserNameOverTransportBindingElement();
            securityHeader.IncludeTimestamp = false;
            securityHeader.MessageSecurityVersion = MessageSecurityVersion.WSSecurity11WSTrustFebruary2005WSSecureConversationFebruary2005WSSecurityPolicy11;

            var customBinding = new CustomBinding(securityHeader,
                new TextMessageEncodingBindingElement(MessageVersion.Soap11, Encoding.UTF8),
                new HttpsTransportBindingElement()
                );

            using (var client = new WS_APC_SS.Webservice_APC_SSClient(customBinding, new EndpointAddress(endPoint)))
            {

                client.ClientCredentials.UserName.UserName = "h00030";
                client.ClientCredentials.UserName.Password = "Awp894Mu";

                var response = client.Alta_SSAsync(request).GetAwaiter().GetResult();

                return response;

            }
        }

        #endregion

        #region "WS_APC_SS_Consulta"

        public static WS_APC_SS_Consulta.GetVersionResponse1 GetVersion2()
        {

            var endPoint = "https://intapp0000.cc.bna.net/Weservice_APC_SS_Consulta"; // TODO : Mover al appsettings.json

            var securityHeader = SecurityBindingElement.CreateUserNameOverTransportBindingElement();
            securityHeader.IncludeTimestamp = false;
            securityHeader.MessageSecurityVersion = MessageSecurityVersion.WSSecurity11WSTrustFebruary2005WSSecureConversationFebruary2005WSSecurityPolicy11;

            var customBinding = new CustomBinding(securityHeader,
                           new TextMessageEncodingBindingElement(MessageVersion.Soap11, Encoding.UTF8),
                           new HttpsTransportBindingElement()
                           );

            using (var client = new WS_APC_SS_Consulta.Weservice_APC_SS_ConsultaClient(customBinding, new EndpointAddress(endPoint)))
            {

                client.ClientCredentials.UserName.UserName = "h00030";
                client.ClientCredentials.UserName.Password = "Awp894Mu";

                var request = new WS_APC_SS_Consulta.GetVersion()
                {
                    SolicitudVersion = new WS_APC_SS_Consulta.T_SolicitudVersion()
                    {
                        Usuario = "H00030",
                        Aplicacion = "PC",
                        Sucursal = 85
                    }
                };

                var response = client.GetVersionAsync(request).GetAwaiter().GetResult();

                return response;

            }
        }

        public static WS_APC_SS_Consulta.Consulta_SSResponse1 Consulta_SS(WS_APC_SS_Consulta.Consulta_SS request)
        {

            var endPoint = "https://intapp0000.cc.bna.net/Weservice_APC_SS_Consulta"; // TODO : Mover al appsettings.json

            var securityHeader = SecurityBindingElement.CreateUserNameOverTransportBindingElement();
            securityHeader.IncludeTimestamp = false;
            securityHeader.MessageSecurityVersion = MessageSecurityVersion.WSSecurity11WSTrustFebruary2005WSSecureConversationFebruary2005WSSecurityPolicy11;

            var customBinding = new CustomBinding(securityHeader,
                           new TextMessageEncodingBindingElement(MessageVersion.Soap11, Encoding.UTF8),
                           new HttpsTransportBindingElement()
                           );

            using (var client = new WS_APC_SS_Consulta.Weservice_APC_SS_ConsultaClient(customBinding, new EndpointAddress(endPoint)))
            {

                client.ClientCredentials.UserName.UserName = "h00030";
                client.ClientCredentials.UserName.Password = "Awp894Mu";


                var response = client.Consulta_SSAsync(request).GetAwaiter().GetResult();

                return response;

            }
        }

        #endregion

    }
}
