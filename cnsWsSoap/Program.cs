using cnsWsSoap.Models;
using Newtonsoft.Json;

/* TODO :
 * Nos falta el usuario asociado al WS Weservice_APC_SS_Consulta
*/

Option option = Option.GET_VERSION_ALTA_SS;


if (option == Option.GET_VERSION_ALTA_SS)
{
    var version = ManagerAPC.GetVersion();

    Console.WriteLine(JsonConvert.SerializeObject(version, Formatting.Indented));
}

if (option == Option.GET_VERSION_CONSULTA_SS)
{
    var version = ManagerAPC.GetVersion2();

    Console.WriteLine(JsonConvert.SerializeObject(version, Formatting.Indented));

}

if (option == Option.ALTA_SS)
{
    
    var request = new WS_APC_SS.Alta_SS()
    {
        Alta_SSRequest = new WS_APC_SS.T_Alta_SS_InputRequest()
        {
            sucursalPresentacion = "2280",
            fabricante = "",
            tipoPersona = "F",
            montoSolicitado = Convert.ToDecimal(100),
            montoSolicitadoSpecified = false,
            telefono = null,
            prioridad = "3 - Media",
            motivo = "",
            correoElectronico = "A@A.COM",
            razonSocial = "",
            observaciones = "Casa: 2280 Producto: 40 Nro. Cuenta: 17221915 Cantidad de Cuotas: 1 Garantía: No",
            fecha = null,
            montoAcordado = Convert.ToDecimal(100),
            montoAcordadoSpecified = true,
            fechaFinCargaSolicitud = "2023-12-23T20:10:33",
            tipoDoc = "DU",
            tipoConsulta = "Gestión",
            sexo = "",
            origen = "Canal Web",
            codigoValidacion = "2280|40|17221915",
            tipoCuit = "2",
            nroDoc = "42143344",
            fechaDeCarga = "2023-12-23T20:10:33",
            estado = "Pendiente Acciones Cliente",
            banca = "Individuos",
            nroCuit = "27421433440",
            fechaNacimientoPFSpecified = false,
            montoRealDolaresSpecified = false,
            exposicion = "",
            testFlag = "N",
            montoRealSpecified = false,
            montoAproximadoSpecified = false,
            sucursalCliente = "",
            subproducto = "",
            producto = "Recupero de Mora",
            resultadoBureau = "Preaprobado",
            productoaComprar = "",
            nroOperacion = "MORA6",
            apellido = "ALARCON",
            sucursalCertificado = "",
            nombre = "MARIELA ALEJANDRA",
            fechaConstitucionSpecified = false,
            canalWS = "Canal Web"
        }
    };

    var alta_ss = ManagerAPC.Alta_SS(request);

    Console.WriteLine(JsonConvert.SerializeObject(alta_ss, Formatting.Indented));

}

if (option == Option.CONSULTA_SS)
{
    var request = new WS_APC_SS_Consulta.Consulta_SS()
    {
        Consulta_SS_Request = new WS_APC_SS_Consulta.T_Consulta_SS_Request()
        {
            codIdent = string.Empty,
            nroOperacion = string.Empty,
            nroSS = string.Empty,
            CUIT = string.Empty,
            testFlag = string.Empty
        }
    };

    var consulta_ss = ManagerAPC.Consulta_SS(request);

    Console.WriteLine(JsonConvert.SerializeObject(consulta_ss, Formatting.Indented));

}

Console.ReadKey();
