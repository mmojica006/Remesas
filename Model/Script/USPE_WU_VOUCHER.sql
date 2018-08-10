USE [CREDIEXPRESS]
GO
/****** Object:  StoredProcedure [dbo].[USPE_WU_VOUCHER]    Script Date: 09/08/2018 16:11:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- create procedure  uspe_com_remesas
ALTER  PROCEDURE [dbo].[USPE_WU_VOUCHER]
 --(
	--@fInicio DATE
	--,@fFin DATE
	--)
AS
BEGIN
	SELECT AGENCIA = 'AIRPAK NICARAGUA, S.A.'
		,TARJETA = ''
		,DESTINATARIO = wa.Destinatario1
		,REMITENTE = wa.Remitente1
		,ID = wa.NumeroID
		,TEL = cast(wa.Telefono as varchar(10))
		,DIRECCION = wa.Direccion1
		,FECHA_HORA = cast(wa.FechaCarga AS VARCHAR) + ' ' + cast(wa.Hora AS VARCHAR)
		,OPERADOR = wa.Operador
		,TIPO_TRANSACCION = wa.Tipo
		,DESTINO = WA.CiudadBeneficiario + ' ' + WA.EstadoBeneficiario
		,ORIGEN = WA.Origen + ' ' + WA.CiudadOrigen
		,PAY_AMOUNT = cast(isnull(wa.Monto, 0) as decimal(15,2))
		,EXCHANGE_RATE = case wr.MonedaOriginal  when  2 then 1 
												when 1  then  cast(wr.TipoCambio AS DECIMAL(15, 2)) end
		,SOURCE_AMOUNT = cast(isnull(wa.Monto, 0) as decimal(15,2))
		,MONEDA_ORINGEN = CASE wa.Moneda
			WHEN 'USD'
				THEN 'Dólar estadounidense'
			WHEN 'LOCAL'
				THEN 'Córdobas'
			ELSE 'N/A'
			END
		,FECHA_ORIGEN = cast(WA.FechaCarga AS DATE)
		,MTCN = cast(wa.MTCN as varchar(15))
		,CARGO_ENVIO = cast(isnull(wr.Comision, 0) as decimal(15,2))
		,CARGO_MENSAJE = '0'
		,CARGO_ENTREGA = '0'
		,IMPUESTO = '0'		
		,TOTAL =   cast(isnull(wa.Monto, 0) as decimal(15,2))
		,FIRMA = wr.Firma

	FROM WU_Remesas wr
	INNER JOIN WU_Apos wa ON wr.MTCN = wa.MTCN
	INNER JOIN USUARIOS(NOLOCK) us ON wr.Usuario = us.INICIALES
		AND us.TZ_LOCK = 0
	INNER JOIN TC_SUCURSALES(NOLOCK) ts ON us.NROSUCURSAL = ts.C6021
		AND ts.TZ_LOCK = 0
	INNER JOIN AU_RelFuncionarioUsr(NOLOCK) ar ON ar.UsuarioTopaz = us.INICIALES
		AND ar.TZ_LOCK = 0
	INNER JOIN RH_Funcionario(NOLOCK) rf ON ar.CodFuncionario = rf.CodFuncionario
	where wa.FechaCarga between '20180601' and '20180630'
	--WHERE wa.FechaCarga BETWEEN @fInicio
	--		AND @fFin
				--and ( ts.C6021 = @vnSucursal or @vnSucursal = 0)
				--and (wr.Estado = @vEstado or @vEstado = 'Z')
END

-- exec USPE_WU_VOUCHER '20180601', '20180630'