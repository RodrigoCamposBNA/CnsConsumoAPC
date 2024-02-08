namespace TestProject
{
    [TestClass]
    public class UnitTestAPC
    {
        [TestMethod]
        public void GetVersion_AltaSS()
        {
            var version = cnsWsSoap.Models.ManagerAPC.GetVersion();

            Assert.AreEqual(0, version.GetVersionResponse.Version.Resultado.Codigo);
        }

        //[TestMethod]
        //public void GetVersion_ConsultaSS()
        //{
        //    var version = cnsWsSoap.Models.ManagerAPC.GetVersion2();

        //    Assert.AreEqual(0, version.GetVersionResponse.Version.Resultado.Codigo);
        //}

        //[TestMethod]
        //public void AltaSS()
        //{
        //    var request = new WS_APC_SS.Alta_SS()
        //    {
        //        Alta_SSRequest = new WS_APC_SS.T_Alta_SS_InputRequest()
        //        {
        //            sucursalPresentacion = "2280",
        //            fabricante = "",
        //            tipoPersona = "F",
        //            montoSolicitado = Convert.ToDecimal(100),
        //            montoSolicitadoSpecified = false,
        //            telefono = null,
        //            prioridad = "3 - Media",
        //            motivo = "",
        //            correoElectronico = "A@A.COM",
        //            razonSocial = "",
        //            observaciones = "Casa: 2280 Producto: 40 Nro. Cuenta: 17221915 Cantidad de Cuotas: 1 Garantía: No",
        //            fecha = null,
        //            montoAcordado = Convert.ToDecimal(100),
        //            montoAcordadoSpecified = true,
        //            fechaFinCargaSolicitud = "2023-12-23T20:10:33",
        //            tipoDoc = "DU",
        //            tipoConsulta = "Gestión",
        //            sexo = "",
        //            origen = "Canal Web",
        //            codigoValidacion = "2280|40|17221915",
        //            tipoCuit = "2",
        //            nroDoc = "42143344",
        //            fechaDeCarga = "2023-12-23T20:10:33",
        //            estado = "Pendiente Acciones Cliente",
        //            banca = "Individuos",
        //            nroCuit = "27421433440",
        //            fechaNacimientoPFSpecified = false,
        //            montoRealDolaresSpecified = false,
        //            exposicion = "",
        //            testFlag = "N",
        //            montoRealSpecified = false,
        //            montoAproximadoSpecified = false,
        //            sucursalCliente = "",
        //            subproducto = "",
        //            producto = "Recupero de Mora",
        //            resultadoBureau = "Preaprobado",
        //            productoaComprar = "",
        //            nroOperacion = "MORA6",
        //            apellido = "ALARCON",
        //            sucursalCertificado = "",
        //            nombre = "MARIELA ALEJANDRA",
        //            fechaConstitucionSpecified = false,
        //            canalWS = "Canal Web"
        //        }
        //    };

        //    var alta_ss = cnsWsSoap.Models.ManagerAPC.Alta_SS(request);

        //    Assert.AreEqual(0, alta_ss.Alta_SSResponse.Alta_SSResponse1.codigo);
        //}

        //[TestMethod]
        //public void ConsultaSS()
        //{

        //    var request = new WS_APC_SS_Consulta.Consulta_SS()
        //    {
        //        Consulta_SS_Request = new WS_APC_SS_Consulta.T_Consulta_SS_Request()
        //        {
        //            codIdent = string.Empty,
        //            nroOperacion = string.Empty,
        //            nroSS = string.Empty,
        //            CUIT = string.Empty,
        //            testFlag = string.Empty
        //        }
        //    };

        //    var consulta_ss = cnsWsSoap.Models.ManagerAPC.Consulta_SS(request);

        //    Assert.AreEqual(0, consulta_ss.Consulta_SSResponse.Consulta_SS_Response.codigo);
        //}
    }
}