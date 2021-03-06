
/****** Object:  StoredProcedure [dbo].[proc_ParametroDet]    Script Date: 08/19/2013 15:17:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO


ALTER Procedure [dbo].[proc_ParametroDet]
(	@accion	char(2), 
	@Parame_Codigo	int=null, 
	@Pardet_Secuencia	int=null, 
	@Pardet_Descripcion	nvarchar(100)=null, 
	@Pardet_DatoStr1	nvarchar(300)=null,
	@Pardet_DatoStr2	nvarchar(200)=null,
	@Pardet_DatoStr3	nvarchar(200)=null,
	@Pardet_DatoInt1	int=null,
	@Pardet_Modificable	bit=null, 
	@Parame_Padre	int=null, 
	@Pardet_Padre		int=null,
	@Pardet_Imagen	image=null,
	@Pardet_Leyenda	text=null,
	@CtaCtb_CtaCtble1	varchar(11)=null,
	@CtaCtb_CtaCtble2	varchar(11)=null,
	@Pardet_DatoDec1	decimal(18,4)=null,
	@Pardet_DatoBit1	bit=null,
	
	--0 Persona	1 Natural		2 Juridica		3 Lugar
	@TipoPersona	int=null,
	@filtro		nvarchar(200)=null)
as
begin
	if @accion='i'
	begin
		declare @codigo int
		select @codigo=isnull(max(Pardet_Secuencia),0)+1 from ParametroDet where Parame_Codigo=@Parame_Codigo

		insert into ParametroDet 
			(Parame_Codigo, Pardet_Secuencia, Pardet_Descripcion, Pardet_DatoStr1, Pardet_DatoStr2, Pardet_DatoStr3, Pardet_Modificable, Parame_Padre, Pardet_Padre, 
			Pardet_Leyenda, Pardet_DatoInt1, CtaCtb_CtaCtble1, CtaCtb_CtaCtble2, Pardet_DatoDec1, Pardet_DatoBit1)
		values (@Parame_Codigo, @Codigo, @Pardet_Descripcion, @Pardet_DatoStr1, @Pardet_DatoStr2, @Pardet_DatoStr3, @Pardet_Modificable, @Parame_Padre, @Pardet_Padre, 
			@Pardet_Leyenda, @Pardet_DatoInt1, @CtaCtb_CtaCtble1, @CtaCtb_CtaCtble2, @Pardet_DatoDec1, @Pardet_DatoBit1)

		/*if @Parame_Codigo=430
			insert into UnidadMedidaConversion
				(Parame_Unidadmedida, Pardet_Unidadmedida, Parame_unidadmedidadestino, Pardet_Unidadmedidadestino, Unmeco_Factor)
			values (@Parame_Codigo, @Codigo, @Parame_Codigo, @Codigo, 1)
 
		if @Parame_Codigo=460
			insert into TipoPagoxTipoPrecio
				(Empres_Codigo, Sucurs_Codigo, Parame_TipoPago, Pardet_TipoPago, Parame_TipoPrecio, Pardet_TipoPrecio)
			select Empres_Codigo, Sucurs_Codigo, @Parame_Codigo, @Codigo, 450, 1 from Sucursal*/

		select @codigo
		return 0
	end
	if @accion='m'
	begin
		update ParametroDet
			set Pardet_Descripcion= @Pardet_Descripcion, Pardet_DatoStr1= @Pardet_DatoStr1, Pardet_DatoStr2= @Pardet_DatoStr2, Pardet_DatoStr3= @Pardet_DatoStr3, Pardet_DatoInt1= @Pardet_DatoInt1,
			Pardet_Modificable= @Pardet_Modificable, Parame_Padre= @Parame_Padre, Pardet_Padre= @Pardet_Padre,
			Pardet_Leyenda= @Pardet_Leyenda, CtaCtb_CtaCtble1= @CtaCtb_CtaCtble1, CtaCtb_CtaCtble2= @CtaCtb_CtaCtble2,
			Pardet_DatoDec1= @Pardet_DatoDec1, Pardet_DatoBit1= @Pardet_DatoBit1
		where Parame_Codigo= @Parame_Codigo and Pardet_Secuencia= @Pardet_Secuencia
		return 0
	end
	if @accion='c'
	begin
		select Parame_Codigo, Pardet_Secuencia, Pardet_Descripcion, Pardet_DatoStr1, Pardet_DatoStr2, Pardet_DatoStr3, Pardet_DatoInt1, Pardet_Modificable, Parame_Padre, Pardet_Padre, 
			Pardet_Leyenda, CtaCtb_CtaCtble1, CtaCtb_CtaCtble2, Pardet_DatoDec1, Pardet_DatoBit1
			from ParametroDet
		where Parame_Codigo= @Parame_Codigo and Pardet_Secuencia= @Pardet_Secuencia
		return 0
	end
	if @accion='pl' --picture load
	begin
		select Pardet_Imagen
			from ParametroDet
		where Parame_Codigo= @Parame_Codigo and Pardet_Secuencia= @Pardet_Secuencia
		return 0
	end
	if @accion='ps' --picture save
	begin
		update ParametroDet set Pardet_Imagen=@Pardet_Imagen
		where Parame_Codigo= @Parame_Codigo and Pardet_Secuencia= @Pardet_Secuencia
		return 0
	end
	if @accion='e'
	begin
		begin transaction
		/*if @Parame_Codigo=430
			delete UnidadMedidaConversion
			where Parame_Unidadmedida= @Parame_Codigo and Pardet_Unidadmedida= @Pardet_Secuencia*/

		if exists (Select * from ParametroDet where Parame_Padre=@Parame_Codigo and Pardet_Padre=@Pardet_Secuencia)
		begin
			raiserror ('No se puede eliminar un nivel superior del árbol', 16, 1)
			rollback transaction
			return -1
		end
		
		delete ParametroDet
		where Parame_Codigo= @Parame_Codigo and Pardet_Secuencia= @Pardet_Secuencia
		commit transaction
		return 0
	end
	if @accion='f'
	begin
		if @TipoPersona=5 and not @Pardet_Padre is null --unidadmedida
			select Parame_Codigo, Pardet_Secuencia, Pardet_Descripcion, Pardet_DatoStr1, Pardet_DatoStr2, Pardet_DatoStr3, Pardet_DatoInt1, Pardet_Modificable, Parame_Padre, Pardet_Padre,
				CtaCtb_CtaCtble1, CtaCtb_CtaCtble2, Pardet_DatoDec1, Pardet_DatoBit1
				from ParametroDet
				where Parame_Codigo= @Parame_Padre
				and Pardet_Secuencia= @Pardet_Padre
			union
			SELECT     dbo.ParametroDet.Parame_Codigo, dbo.ParametroDet.Pardet_Secuencia, dbo.ParametroDet.Pardet_Descripcion, 
				dbo.ParametroDet.Pardet_DatoStr1, Pardet_DatoStr2, Pardet_DatoStr3, Pardet_DatoInt1,
			                      dbo.ParametroDet.Pardet_Modificable, dbo.ParametroDet.Parame_Padre, dbo.ParametroDet.Pardet_Padre,
				CtaCtb_CtaCtble1, CtaCtb_CtaCtble2, Pardet_DatoDec1, Pardet_DatoBit1
			FROM         dbo.ParametroDet INNER JOIN
			                      dbo.UnidadMedidaConversion ON dbo.ParametroDet.Parame_Codigo = dbo.UnidadMedidaConversion.Parame_unidadmedidadestino AND 
			                      dbo.ParametroDet.Pardet_Secuencia = dbo.UnidadMedidaConversion.Pardet_Unidadmedidadestino
			where dbo.UnidadMedidaConversion.Parame_Unidadmedida=@Parame_Padre
			and dbo.UnidadMedidaConversion.Pardet_Unidadmedida= @Pardet_Padre
		else
			select Parame_Codigo, Pardet_Secuencia, Pardet_Descripcion, Pardet_DatoStr1, Pardet_DatoStr2, Pardet_DatoStr3, Pardet_DatoInt1, Pardet_Modificable, Parame_Padre, Pardet_Padre, 
				Pardet_Leyenda, CtaCtb_CtaCtble1, CtaCtb_CtaCtble2, Pardet_DatoDec1, Pardet_DatoBit1
				from ParametroDet
				where coalesce(@Parame_Codigo, Parame_Codigo)= Parame_Codigo
				and (case 
					when @TipoPersona is null and @Parame_Padre is null and @Pardet_Padre is null then 1 
					when @TipoPersona is null and coalesce(@Parame_Padre, Parame_Padre)=Parame_Padre 
						and coalesce(@Pardet_Padre, Pardet_Padre)=Pardet_Padre
						then 1 
					when @TipoPersona=1 and 
						((Parame_Padre=100 and Pardet_Padre=1) 
							or (Parame_Padre=110 and Pardet_Padre=1) 
							or (Parame_Padre=null and Pardet_Padre=null)) then 1
					when @TipoPersona=2 and 
						((Parame_Padre=100 and Pardet_Padre=1) 
							or (Parame_Padre=110 and Pardet_Padre=2) 
							or (Parame_Padre=null and Pardet_Padre=null)) then 1
					when @TipoPersona=3 and 
						((Parame_Padre=100 and Pardet_Padre=2) 
							or (Parame_Padre=115 and Pardet_Padre=1)) then 1
					when @TipoPersona=4 and 
						((Parame_Padre=100 and Pardet_Padre=2) 
							or (Parame_Padre=115 and Pardet_Padre=2)) then 1
					else 0 end)=1
			and (case when @filtro is null then 1
				when Pardet_Descripcion like '%' + @filtro + '%' then 1
				else 0 end)=1
			order by 3
			--0 Persona	1 Natural		2 Juridica		3 Sucursal		4 Bodega		5 UnidMed
		return 0
	end
	if @accion='fc'
	begin
		if @TipoPersona=5 and not @Pardet_Padre is null --unidadmedida
			select Parame_Codigo, Pardet_Secuencia, Pardet_Descripcion, Pardet_DatoStr1, Pardet_DatoStr2, Pardet_DatoStr3, Pardet_DatoInt1, Pardet_Modificable, Parame_Padre, Pardet_Padre,
				CtaCtb_CtaCtble1, CtaCtb_CtaCtble2, Pardet_DatoDec1, Pardet_DatoBit1
				from ParametroDet
				where Parame_Codigo= @Parame_Padre
				and Pardet_Secuencia= @Pardet_Padre
			union
			SELECT     dbo.ParametroDet.Parame_Codigo, dbo.ParametroDet.Pardet_Secuencia, dbo.ParametroDet.Pardet_Descripcion, 
				dbo.ParametroDet.Pardet_DatoStr1, Pardet_DatoStr2, Pardet_DatoStr3, Pardet_DatoInt1,
			                      dbo.ParametroDet.Pardet_Modificable, dbo.ParametroDet.Parame_Padre, dbo.ParametroDet.Pardet_Padre,
				CtaCtb_CtaCtble1, CtaCtb_CtaCtble2, Pardet_DatoDec1, Pardet_DatoBit1
			FROM         dbo.ParametroDet INNER JOIN
			                      dbo.UnidadMedidaConversion ON dbo.ParametroDet.Parame_Codigo = dbo.UnidadMedidaConversion.Parame_unidadmedidadestino AND 
			                      dbo.ParametroDet.Pardet_Secuencia = dbo.UnidadMedidaConversion.Pardet_Unidadmedidadestino
			where dbo.UnidadMedidaConversion.Parame_Unidadmedida=@Parame_Padre
			and dbo.UnidadMedidaConversion.Pardet_Unidadmedida= @Pardet_Padre
		else
			select Parame_Codigo, Pardet_Secuencia, Pardet_Descripcion, Pardet_DatoStr1, Pardet_DatoStr2, Pardet_DatoStr3, Pardet_DatoInt1, Pardet_Modificable, Parame_Padre, Pardet_Padre, 
				Pardet_Leyenda, CtaCtb_CtaCtble1, CtaCtb_CtaCtble2, Pardet_DatoDec1, Pardet_DatoBit1
				from ParametroDet
				where coalesce(@Parame_Codigo, Parame_Codigo)= Parame_Codigo
				and (case 
					when @TipoPersona is null and @Parame_Padre is null and @Pardet_Padre is null then 1 
					when @TipoPersona is null and coalesce(@Parame_Padre, Parame_Padre)=Parame_Padre 
						and coalesce(@Pardet_Padre, Pardet_Padre)=Pardet_Padre
						then 1 
					when @TipoPersona=1 and 
						((Parame_Padre=100 and Pardet_Padre=1) 
							or (Parame_Padre=110 and Pardet_Padre=1) 
							or (Parame_Padre=null and Pardet_Padre=null)) then 1
					when @TipoPersona=2 and 
						((Parame_Padre=100 and Pardet_Padre=1) 
							or (Parame_Padre=110 and Pardet_Padre=2) 
							or (Parame_Padre=null and Pardet_Padre=null)) then 1
					when @TipoPersona=3 and 
						((Parame_Padre=100 and Pardet_Padre=2) 
							or (Parame_Padre=115 and Pardet_Padre=1)) then 1
					when @TipoPersona=4 and 
						((Parame_Padre=100 and Pardet_Padre=2) 
							or (Parame_Padre=115 and Pardet_Padre=2)) then 1
					else 0 end)=1
			and (case when @filtro is null then 1
				when Pardet_Descripcion like '%' + @filtro + '%' then 1
				else 0 end)=1
			order by 2
			--0 Persona	1 Natural		2 Juridica		3 Sucursal		4 Bodega		5 UnidMed
		return 0
	end
end
