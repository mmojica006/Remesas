USE [CREDIEXPRESS]
GO
/****** Object:  StoredProcedure [dbo].[USPE_WU_VOUCHER]    Script Date: 09/08/2018 16:11:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- create procedure  uspe_com_remesas
ALTER  PROCEDURE [dbo].[USPE_WU_VOUCHER]
 (
	@fInicio DATE
	,@fFin DATE
	)
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
		,PAY_AMOUNT =  case wa.MonedaOriginalTransaccionTL  when  'USD' then  cast(isnull(wa.Monto, 0) as decimal(15,2))
															else cast(isnull(wr.MontoEntrega , 0) as decimal(15,2)) end
		,EXCHANGE_RATE = case wa.MonedaOriginalTransaccionTL  when  'USD' then 1 
												when 'LOCAL'  then 1 end
		,SOURCE_AMOUNT = case wa.MonedaOriginalTransaccionTL  when  'USD' then cast(isnull(wa.Monto, 0) as decimal(15,2))
																else cast(isnull(wr.MontoEntrega , 0) as decimal(15,2)) end
		,MONEDA_ORINGEN = CASE wa.MonedaOriginalTransaccionTL
			WHEN 'USD'
				THEN 'Dólar estadounidense'
			WHEN 'LOCAL'
				THEN 'Córdobas'
			ELSE 'N/A'
			END
		,FECHA_ORIGEN = cast(WA.FechaCarga AS DATE)
		,MTCN = cast(wa.MTCN as varchar(15))
		,CARGO_ENVIO ='0'
		,CARGO_MENSAJE = '0'
		,CARGO_ENTREGA = '0'
		,IMPUESTO = '0'		
		,TOTAL =  case wa.MonedaOriginalTransaccionTL  when  'USD' then  cast(isnull(wa.Monto, 0) as decimal(15,2))
													  when 'LOCAL' THEN cast(isnull(wr.MontoEntrega , 0) as decimal(15,2))  end
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
	where wa.FechaCarga between @fInicio and @fFin
	--WHERE wa.FechaCarga BETWEEN @fInicio
	--		AND @fFin
				--and ( ts.C6021 = @vnSucursal or @vnSucursal = 0)
				--and (wr.Estado = @vEstado or @vEstado = 'Z')
END

-- exec USPE_WU_VOUCHER '20180701', '20180710'