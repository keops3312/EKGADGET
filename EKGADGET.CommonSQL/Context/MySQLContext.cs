namespace EKGADGET.CommonSQL.Context
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MySQLContext : DbContext
    {
        public MySQLContext()
            : base("MySQLContext")
        {
        }

        public virtual DbSet<artventas> artventas { get; set; }
        public virtual DbSet<contratos> contratos { get; set; }
        public virtual DbSet<Localidades> Localidades { get; set; }
        public virtual DbSet<abono> abono { get; set; }
        public virtual DbSet<almacenaje> almacenaje { get; set; }
        public virtual DbSet<anterior_abono> anterior_abono { get; set; }
        public virtual DbSet<Apartados> Apartados { get; set; }
        public virtual DbSet<Apartados_confg> Apartados_confg { get; set; }
        public virtual DbSet<artventas101> artventas101 { get; set; }
        public virtual DbSet<artventas201> artventas201 { get; set; }
        public virtual DbSet<artventas501> artventas501 { get; set; }
        public virtual DbSet<artventas901> artventas901 { get; set; }
        public virtual DbSet<Auditoria> Auditoria { get; set; }
        public virtual DbSet<auditoria_fisica> auditoria_fisica { get; set; }
        public virtual DbSet<auditoria_resumen> auditoria_resumen { get; set; }
        public virtual DbSet<autorizaciones_prestamos> autorizaciones_prestamos { get; set; }
        public virtual DbSet<auxiliar_puesto> auxiliar_puesto { get; set; }
        public virtual DbSet<bolsas_ORO> bolsas_ORO { get; set; }
        public virtual DbSet<bolsas_OTROS> bolsas_OTROS { get; set; }
        public virtual DbSet<borrorem> borrorem { get; set; }
        public virtual DbSet<CAJA_AUXILIAR> CAJA_AUXILIAR { get; set; }
        public virtual DbSet<caja1> caja1 { get; set; }
        public virtual DbSet<calificacion_aud> calificacion_aud { get; set; }
        public virtual DbSet<clasificacion_cl> clasificacion_cl { get; set; }
        public virtual DbSet<clientes> clientes { get; set; }
        public virtual DbSet<CLON_APARTADOS> CLON_APARTADOS { get; set; }
        public virtual DbSet<CLON_contratos> CLON_contratos { get; set; }
        public virtual DbSet<CLONA> CLONA { get; set; }
        public virtual DbSet<clonartventas> clonartventas { get; set; }
        public virtual DbSet<CLONB> CLONB { get; set; }
        public virtual DbSet<clontabla> clontabla { get; set; }
        public virtual DbSet<cobros_poliza> cobros_poliza { get; set; }
        public virtual DbSet<comprobaciones> comprobaciones { get; set; }
        public virtual DbSet<comprobaciones_gastos> comprobaciones_gastos { get; set; }
        public virtual DbSet<Config_valores_plazos> Config_valores_plazos { get; set; }
        public virtual DbSet<contabilidad> contabilidad { get; set; }
        public virtual DbSet<contrato_conta> contrato_conta { get; set; }
        public virtual DbSet<Contrato_temporal> Contrato_temporal { get; set; }
        public virtual DbSet<CORREO> CORREO { get; set; }
        public virtual DbSet<costo_reimpresion> costo_reimpresion { get; set; }
        public virtual DbSet<depositos> depositos { get; set; }
        public virtual DbSet<depositos_tipo> depositos_tipo { get; set; }
        public virtual DbSet<descuentos_distintos> descuentos_distintos { get; set; }
        public virtual DbSet<documentos> documentos { get; set; }
        public virtual DbSet<Empleados> Empleados { get; set; }
        public virtual DbSet<Empresas> Empresas { get; set; }
        public virtual DbSet<Envios> Envios { get; set; }
        public virtual DbSet<estado_civil> estado_civil { get; set; }
        public virtual DbSet<EstadosRepublica> EstadosRepublica { get; set; }
        public virtual DbSet<EstatusApartado> EstatusApartado { get; set; }
        public virtual DbSet<EstatusContratos> EstatusContratos { get; set; }
        public virtual DbSet<EstatusInventarios> EstatusInventarios { get; set; }
        public virtual DbSet<ETQ_VENTA> ETQ_VENTA { get; set; }
        public virtual DbSet<FactCO> FactCO { get; set; }
        public virtual DbSet<FactCTR> FactCTR { get; set; }
        public virtual DbSet<factura_conta> factura_conta { get; set; }
        public virtual DbSet<facturas> facturas { get; set; }
        public virtual DbSet<fechasAU> fechasAU { get; set; }
        public virtual DbSet<gastos> gastos { get; set; }
        public virtual DbSet<GradoEstudios> GradoEstudios { get; set; }
        public virtual DbSet<INFS> INFS { get; set; }
        public virtual DbSet<interes> interes { get; set; }
        public virtual DbSet<interes_conta> interes_conta { get; set; }
        public virtual DbSet<inventariopromocion> inventariopromocion { get; set; }
        public virtual DbSet<marcas_localidad> marcas_localidad { get; set; }
        public virtual DbSet<Niveles_acceso> Niveles_acceso { get; set; }
        public virtual DbSet<Noticias_SEMP2013> Noticias_SEMP2013 { get; set; }
        public virtual DbSet<paises> paises { get; set; }
        public virtual DbSet<prestamos_poliza> prestamos_poliza { get; set; }
        public virtual DbSet<PRG11> PRG11 { get; set; }
        public virtual DbSet<PRG12> PRG12 { get; set; }
        public virtual DbSet<prom_aplica> prom_aplica { get; set; }
        public virtual DbSet<prom_aumento> prom_aumento { get; set; }
        public virtual DbSet<prom_descuento_interes> prom_descuento_interes { get; set; }
        public virtual DbSet<prom_ventas> prom_ventas { get; set; }
        public virtual DbSet<promocioncaja> promocioncaja { get; set; }
        public virtual DbSet<promociones> promociones { get; set; }
        public virtual DbSet<promociones_Activas> promociones_Activas { get; set; }
        public virtual DbSet<promocionesregalo> promocionesregalo { get; set; }
        public virtual DbSet<PRVyusuarios> PRVyusuarios { get; set; }
        public virtual DbSet<Puestos> Puestos { get; set; }
        public virtual DbSet<puntos_confg> puntos_confg { get; set; }
        public virtual DbSet<refrendo> refrendo { get; set; }
        public virtual DbSet<Reimpresiones> Reimpresiones { get; set; }
        public virtual DbSet<remate_inventarios> remate_inventarios { get; set; }
        public virtual DbSet<remisiones> remisiones { get; set; }
        public virtual DbSet<Respaldos> Respaldos { get; set; }
        public virtual DbSet<Retiros> Retiros { get; set; }
        public virtual DbSet<seguro> seguro { get; set; }
        public virtual DbSet<selcaja> selcaja { get; set; }
        public virtual DbSet<sexos> sexos { get; set; }
        public virtual DbSet<siglasempresa> siglasempresa { get; set; }
        public virtual DbSet<tabla_result> tabla_result { get; set; }
        public virtual DbSet<TASA_PRESTAMOS> TASA_PRESTAMOS { get; set; }
        public virtual DbSet<TEMP_AVALUO> TEMP_AVALUO { get; set; }
        public virtual DbSet<TEMP_AVALUO2> TEMP_AVALUO2 { get; set; }
        public virtual DbSet<tipos_localidad> tipos_localidad { get; set; }
        public virtual DbSet<TPavaluos> TPavaluos { get; set; }
        public virtual DbSet<transferencias> transferencias { get; set; }
        public virtual DbSet<TRFENTRADA> TRFENTRADA { get; set; }
        public virtual DbSet<VALOR_FACTORES> VALOR_FACTORES { get; set; }
        public virtual DbSet<VALOR_FACTORES_MAS> VALOR_FACTORES_MAS { get; set; }
        public virtual DbSet<vencidos> vencidos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<artventas>()
                .Property(e => e.preciosugerido)
                .HasPrecision(19, 4);

            modelBuilder.Entity<artventas>()
                .Property(e => e.precioventa)
                .HasPrecision(19, 4);

            modelBuilder.Entity<artventas>()
                .Property(e => e.precio_promocion)
                .HasPrecision(19, 4);

            modelBuilder.Entity<artventas>()
                .Property(e => e.precioPromo2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<artventas>()
                .Property(e => e.precioPromo3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<artventas>()
                .Property(e => e.precioRemate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<artventas>()
                .Property(e => e.precio_origen)
                .HasPrecision(19, 4);

            modelBuilder.Entity<artventas>()
                .Property(e => e.prestamo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<contratos>()
                .Property(e => e.Comentario)
                .IsUnicode(false);

            modelBuilder.Entity<contratos>()
                .Property(e => e.Prestamo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<contratos>()
                .Property(e => e.avaluo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<contratos>()
                .Property(e => e.comentariocancelado)
                .IsUnicode(false);

            modelBuilder.Entity<contratos>()
                .Property(e => e.prestamoprom)
                .HasPrecision(19, 4);

            modelBuilder.Entity<contratos>()
                .Property(e => e.santerior)
                .IsFixedLength();

            modelBuilder.Entity<contratos>()
                .Property(e => e.pension)
                .IsFixedLength();

            modelBuilder.Entity<Localidades>()
                .Property(e => e.objetivoMEs)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Localidades>()
                .Property(e => e.formato)
                .IsFixedLength();

            modelBuilder.Entity<Localidades>()
                .Property(e => e.CAS)
                .IsUnicode(false);

            modelBuilder.Entity<Localidades>()
                .Property(e => e.Hora)
                .HasPrecision(0);

            modelBuilder.Entity<abono>()
                .Property(e => e.prestamo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<abono>()
                .Property(e => e.abonado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<almacenaje>()
                .Property(e => e.almacenaje1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<anterior_abono>()
                .Property(e => e.valor_prenda)
                .HasPrecision(19, 4);

            modelBuilder.Entity<anterior_abono>()
                .Property(e => e.prestamo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Apartados>()
                .Property(e => e.detalles)
                .IsUnicode(false);

            modelBuilder.Entity<Apartados>()
                .Property(e => e.preciosugerido)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Apartados>()
                .Property(e => e.precioventa)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Apartados>()
                .Property(e => e.apartado_cantidad)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Apartados>()
                .Property(e => e.resta_por_pagar)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Apartados>()
                .Property(e => e.comentario)
                .IsUnicode(false);

            modelBuilder.Entity<Apartados>()
                .Property(e => e.penalizado_precio)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Apartados>()
                .Property(e => e.mot_cancelo)
                .IsUnicode(false);

            modelBuilder.Entity<Apartados>()
                .Property(e => e.precio_origen)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Apartados>()
                .Property(e => e.precio_remate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<artventas101>()
                .Property(e => e.detalles)
                .IsUnicode(false);

            modelBuilder.Entity<artventas101>()
                .Property(e => e.preciosugerido)
                .HasPrecision(19, 4);

            modelBuilder.Entity<artventas101>()
                .Property(e => e.precioventa)
                .HasPrecision(19, 4);

            modelBuilder.Entity<artventas101>()
                .Property(e => e.precio_promocion)
                .HasPrecision(19, 4);

            modelBuilder.Entity<artventas201>()
                .Property(e => e.detalles)
                .IsUnicode(false);

            modelBuilder.Entity<artventas201>()
                .Property(e => e.preciosugerido)
                .HasPrecision(19, 4);

            modelBuilder.Entity<artventas201>()
                .Property(e => e.precioventa)
                .HasPrecision(19, 4);

            modelBuilder.Entity<artventas201>()
                .Property(e => e.precio_promocion)
                .HasPrecision(19, 4);

            modelBuilder.Entity<artventas201>()
                .Property(e => e.precioPromo2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<artventas201>()
                .Property(e => e.precioPromo3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<artventas201>()
                .Property(e => e.precioRemate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<artventas201>()
                .Property(e => e.precio_origen)
                .HasPrecision(19, 4);

            modelBuilder.Entity<artventas201>()
                .Property(e => e.prestamo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<artventas501>()
                .Property(e => e.detalles)
                .IsUnicode(false);

            modelBuilder.Entity<artventas501>()
                .Property(e => e.preciosugerido)
                .HasPrecision(19, 4);

            modelBuilder.Entity<artventas501>()
                .Property(e => e.precioventa)
                .HasPrecision(19, 4);

            modelBuilder.Entity<artventas501>()
                .Property(e => e.precio_promocion)
                .HasPrecision(19, 4);

            modelBuilder.Entity<artventas901>()
                .Property(e => e.detalles)
                .IsUnicode(false);

            modelBuilder.Entity<artventas901>()
                .Property(e => e.preciosugerido)
                .HasPrecision(19, 4);

            modelBuilder.Entity<artventas901>()
                .Property(e => e.precioventa)
                .HasPrecision(19, 4);

            modelBuilder.Entity<artventas901>()
                .Property(e => e.precio_promocion)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Auditoria>()
                .Property(e => e.Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<Auditoria>()
                .Property(e => e.Procedimiento)
                .IsUnicode(false);

            modelBuilder.Entity<Auditoria>()
                .Property(e => e.Area)
                .IsUnicode(false);

            modelBuilder.Entity<auditoria_fisica>()
                .Property(e => e.prendas)
                .HasPrecision(19, 4);

            modelBuilder.Entity<autorizaciones_prestamos>()
                .Property(e => e.anterior)
                .HasPrecision(19, 4);

            modelBuilder.Entity<autorizaciones_prestamos>()
                .Property(e => e.nuevo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<bolsas_ORO>()
                .Property(e => e.Avaluo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<bolsas_ORO>()
                .Property(e => e.Prestamo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<bolsas_OTROS>()
                .Property(e => e.Avaluo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<bolsas_OTROS>()
                .Property(e => e.Condiciones)
                .IsUnicode(false);

            modelBuilder.Entity<bolsas_OTROS>()
                .Property(e => e.prestamo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<bolsas_OTROS>()
                .Property(e => e.detalles)
                .IsUnicode(false);

            modelBuilder.Entity<CAJA_AUXILIAR>()
                .Property(e => e.Apartado_no)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CAJA_AUXILIAR>()
                .Property(e => e.abono)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CAJA_AUXILIAR>()
                .Property(e => e.abono_acumulado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CAJA_AUXILIAR>()
                .Property(e => e.debe)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CAJA_AUXILIAR>()
                .Property(e => e.haber)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CAJA_AUXILIAR>()
                .Property(e => e.Saldo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CAJA_AUXILIAR>()
                .Property(e => e.otros_saldo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CAJA_AUXILIAR>()
                .Property(e => e.Comentario)
                .IsUnicode(false);

            modelBuilder.Entity<CAJA_AUXILIAR>()
                .Property(e => e.debe2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CAJA_AUXILIAR>()
                .Property(e => e.haber2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CAJA_AUXILIAR>()
                .Property(e => e.otros_saldo2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<calificacion_aud>()
                .Property(e => e.detalles)
                .IsUnicode(false);

            modelBuilder.Entity<calificacion_aud>()
                .Property(e => e.concepto)
                .IsUnicode(false);

            modelBuilder.Entity<clasificacion_cl>()
                .Property(e => e.Importes1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<clasificacion_cl>()
                .Property(e => e.Importes2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<clasificacion_cl>()
                .Property(e => e.Importes3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<clasificacion_cl>()
                .Property(e => e.Importes4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<clasificacion_cl>()
                .Property(e => e.Importes5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<clasificacion_cl>()
                .Property(e => e.cantidad1)
                .HasPrecision(18, 0);

            modelBuilder.Entity<clasificacion_cl>()
                .Property(e => e.cantidad2)
                .HasPrecision(18, 0);

            modelBuilder.Entity<clasificacion_cl>()
                .Property(e => e.cantidad3)
                .HasPrecision(18, 0);

            modelBuilder.Entity<clasificacion_cl>()
                .Property(e => e.cantidad4)
                .HasPrecision(18, 0);

            modelBuilder.Entity<clasificacion_cl>()
                .Property(e => e.cantidad5)
                .HasPrecision(18, 0);

            modelBuilder.Entity<clientes>()
                .Property(e => e.puntos_cliente)
                .HasPrecision(18, 0);

            modelBuilder.Entity<clientes>()
                .Property(e => e.PUNTOS_USADOS)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CLON_APARTADOS>()
                .Property(e => e.Apartado_no)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CLON_APARTADOS>()
                .Property(e => e.abono)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CLON_APARTADOS>()
                .Property(e => e.abono_acumulado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CLON_APARTADOS>()
                .Property(e => e.debe)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CLON_APARTADOS>()
                .Property(e => e.haber)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CLON_APARTADOS>()
                .Property(e => e.Saldo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CLON_APARTADOS>()
                .Property(e => e.otros_saldo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CLON_APARTADOS>()
                .Property(e => e.Comentario)
                .IsUnicode(false);

            modelBuilder.Entity<CLON_APARTADOS>()
                .Property(e => e.debe2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CLON_APARTADOS>()
                .Property(e => e.haber2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CLON_APARTADOS>()
                .Property(e => e.otros_saldo2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CLON_contratos>()
                .Property(e => e.Comentario)
                .IsUnicode(false);

            modelBuilder.Entity<CLON_contratos>()
                .Property(e => e.Prestamo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CLON_contratos>()
                .Property(e => e.avaluo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CLON_contratos>()
                .Property(e => e.comentariocancelado)
                .IsUnicode(false);

            modelBuilder.Entity<CLON_contratos>()
                .Property(e => e.prestamoprom)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CLON_contratos>()
                .Property(e => e.santerior)
                .IsFixedLength();

            modelBuilder.Entity<CLON_contratos>()
                .Property(e => e.pension)
                .IsFixedLength();

            modelBuilder.Entity<CLONA>()
                .Property(e => e.Comentario)
                .IsUnicode(false);

            modelBuilder.Entity<CLONA>()
                .Property(e => e.Prestamo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CLONA>()
                .Property(e => e.avaluo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CLONA>()
                .Property(e => e.comentariocancelado)
                .IsUnicode(false);

            modelBuilder.Entity<CLONA>()
                .Property(e => e.prestamoprom)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CLONA>()
                .Property(e => e.santerior)
                .IsFixedLength();

            modelBuilder.Entity<CLONA>()
                .Property(e => e.pension)
                .IsFixedLength();

            modelBuilder.Entity<clonartventas>()
                .Property(e => e.preciosugerido)
                .HasPrecision(19, 4);

            modelBuilder.Entity<clonartventas>()
                .Property(e => e.precioventa)
                .HasPrecision(19, 4);

            modelBuilder.Entity<clonartventas>()
                .Property(e => e.precio_promocion)
                .HasPrecision(19, 4);

            modelBuilder.Entity<clonartventas>()
                .Property(e => e.precioPromo2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<clonartventas>()
                .Property(e => e.precioPromo3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<clonartventas>()
                .Property(e => e.precioRemate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<clonartventas>()
                .Property(e => e.precio_origen)
                .HasPrecision(19, 4);

            modelBuilder.Entity<clonartventas>()
                .Property(e => e.prestamo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CLONB>()
                .Property(e => e.Comentario)
                .IsUnicode(false);

            modelBuilder.Entity<CLONB>()
                .Property(e => e.Prestamo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CLONB>()
                .Property(e => e.avaluo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CLONB>()
                .Property(e => e.comentariocancelado)
                .IsUnicode(false);

            modelBuilder.Entity<CLONB>()
                .Property(e => e.prestamoprom)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CLONB>()
                .Property(e => e.santerior)
                .IsFixedLength();

            modelBuilder.Entity<CLONB>()
                .Property(e => e.pension)
                .IsFixedLength();

            modelBuilder.Entity<clontabla>()
                .Property(e => e.Debe)
                .HasPrecision(19, 4);

            modelBuilder.Entity<clontabla>()
                .Property(e => e.Haber)
                .HasPrecision(19, 4);

            modelBuilder.Entity<clontabla>()
                .Property(e => e.Saldo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<clontabla>()
                .Property(e => e.Comentario)
                .IsUnicode(false);

            modelBuilder.Entity<comprobaciones>()
                .Property(e => e.dir)
                .IsUnicode(false);

            modelBuilder.Entity<comprobaciones_gastos>()
                .Property(e => e.cantidad)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Contrato_temporal>()
                .Property(e => e.monto_prestamo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Contrato_temporal>()
                .Property(e => e.Interes)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Contrato_temporal>()
                .Property(e => e.Seguro)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Contrato_temporal>()
                .Property(e => e.Almacenaje)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Contrato_temporal>()
                .Property(e => e.Total_a_pagar)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Contrato_temporal>()
                .Property(e => e.Refrendo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<costo_reimpresion>()
                .Property(e => e.costo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<depositos>()
                .Property(e => e.deposito)
                .HasPrecision(19, 4);

            modelBuilder.Entity<depositos>()
                .Property(e => e.comentario)
                .IsUnicode(false);

            modelBuilder.Entity<descuentos_distintos>()
                .Property(e => e.R_D)
                .IsFixedLength();

            modelBuilder.Entity<descuentos_distintos>()
                .Property(e => e.A_desempeñar)
                .HasPrecision(19, 4);

            modelBuilder.Entity<descuentos_distintos>()
                .Property(e => e.D_desempeñar)
                .HasPrecision(19, 4);

            modelBuilder.Entity<descuentos_distintos>()
                .Property(e => e.A_refrendar)
                .HasPrecision(19, 4);

            modelBuilder.Entity<descuentos_distintos>()
                .Property(e => e.D_refrendar)
                .HasPrecision(19, 4);

            modelBuilder.Entity<descuentos_distintos>()
                .Property(e => e.antes_prestamo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<descuentos_distintos>()
                .Property(e => e.ahora_prestamo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<descuentos_distintos>()
                .Property(e => e.antes_pension)
                .HasPrecision(19, 4);

            modelBuilder.Entity<descuentos_distintos>()
                .Property(e => e.ahora_pension)
                .HasPrecision(19, 4);

            modelBuilder.Entity<descuentos_distintos>()
                .Property(e => e.antes_resmision)
                .HasPrecision(19, 4);

            modelBuilder.Entity<descuentos_distintos>()
                .Property(e => e.ahora_remision)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ETQ_VENTA>()
                .Property(e => e.Precio)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ETQ_VENTA>()
                .Property(e => e.especial)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ETQ_VENTA>()
                .Property(e => e.REMATE_UNO)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ETQ_VENTA>()
                .Property(e => e.REMATE_DOS)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ETQ_VENTA>()
                .Property(e => e.REMATE_TRES)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FactCO>()
                .Property(e => e.valor_24)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FactCO>()
                .Property(e => e.valor_22)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FactCO>()
                .Property(e => e.valor_18)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FactCO>()
                .Property(e => e.valor_14)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FactCO>()
                .Property(e => e.valor_12)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FactCO>()
                .Property(e => e.valor_10)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FactCO>()
                .Property(e => e.valor_8)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FactCTR>()
                .Property(e => e.sugerido)
                .IsFixedLength();

            modelBuilder.Entity<facturas>()
                .Property(e => e.DescripcionFact)
                .IsUnicode(false);

            modelBuilder.Entity<facturas>()
                .Property(e => e.ImporteFact)
                .HasPrecision(19, 4);

            modelBuilder.Entity<facturas>()
                .Property(e => e.IVAFact)
                .HasPrecision(19, 4);

            modelBuilder.Entity<facturas>()
                .Property(e => e.TotalFact)
                .HasPrecision(19, 4);

            modelBuilder.Entity<facturas>()
                .Property(e => e.Comentario)
                .IsUnicode(false);

            modelBuilder.Entity<facturas>()
                .Property(e => e.Abono)
                .HasPrecision(19, 4);

            modelBuilder.Entity<facturas>()
                .Property(e => e.Gastos_Operacion)
                .HasPrecision(19, 4);

            modelBuilder.Entity<facturas>()
                .Property(e => e.gastos)
                .HasPrecision(19, 4);

            modelBuilder.Entity<facturas>()
                .Property(e => e.descuento_gastos_op)
                .HasPrecision(19, 4);

            modelBuilder.Entity<facturas>()
                .Property(e => e.total_gastos_op)
                .HasPrecision(19, 4);

            modelBuilder.Entity<facturas>()
                .Property(e => e.Nota)
                .IsUnicode(false);

            modelBuilder.Entity<facturas>()
                .Property(e => e.antes_refrendo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<facturas>()
                .Property(e => e.ahora_refrendo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<facturas>()
                .Property(e => e.antes_desempeño)
                .HasPrecision(19, 4);

            modelBuilder.Entity<facturas>()
                .Property(e => e.ahora_desempeño)
                .HasPrecision(19, 4);

            modelBuilder.Entity<facturas>()
                .Property(e => e.interes_N)
                .HasPrecision(19, 4);

            modelBuilder.Entity<facturas>()
                .Property(e => e.interes_A)
                .HasPrecision(19, 4);

            modelBuilder.Entity<INFS>()
                .Property(e => e.localidad)
                .IsUnicode(false);

            modelBuilder.Entity<INFS>()
                .Property(e => e.prestamos_n)
                .HasPrecision(10, 2);

            modelBuilder.Entity<INFS>()
                .Property(e => e.prestamos_r)
                .HasPrecision(10, 2);

            modelBuilder.Entity<INFS>()
                .Property(e => e.n_pago_d)
                .HasPrecision(10, 2);

            modelBuilder.Entity<INFS>()
                .Property(e => e.n_pago_r)
                .HasPrecision(10, 2);

            modelBuilder.Entity<INFS>()
                .Property(e => e.rem_v)
                .HasPrecision(10, 2);

            modelBuilder.Entity<INFS>()
                .Property(e => e.depositos)
                .HasPrecision(10, 2);

            modelBuilder.Entity<INFS>()
                .Property(e => e.retiros)
                .HasPrecision(10, 2);

            modelBuilder.Entity<INFS>()
                .Property(e => e.obsequio)
                .HasPrecision(10, 2);

            modelBuilder.Entity<INFS>()
                .Property(e => e.saldo_caja_in)
                .HasPrecision(10, 2);

            modelBuilder.Entity<INFS>()
                .Property(e => e.saldo_caja_fin)
                .HasPrecision(10, 2);

            modelBuilder.Entity<INFS>()
                .Property(e => e.caja_loc)
                .IsUnicode(false);

            modelBuilder.Entity<INFS>()
                .Property(e => e.usuario_cj)
                .IsUnicode(false);

            modelBuilder.Entity<INFS>()
                .Property(e => e.cancel_p)
                .HasPrecision(10, 2);

            modelBuilder.Entity<INFS>()
                .Property(e => e.cancel_np)
                .HasPrecision(10, 2);

            modelBuilder.Entity<INFS>()
                .Property(e => e.cancel_rem)
                .HasPrecision(10, 2);

            modelBuilder.Entity<INFS>()
                .Property(e => e.p_autos)
                .HasPrecision(10, 2);

            modelBuilder.Entity<INFS>()
                .Property(e => e.p_joyeria)
                .HasPrecision(10, 2);

            modelBuilder.Entity<INFS>()
                .Property(e => e.p_elect)
                .HasPrecision(10, 2);

            modelBuilder.Entity<INFS>()
                .Property(e => e.p_otr)
                .HasPrecision(10, 2);

            modelBuilder.Entity<INFS>()
                .Property(e => e.abono)
                .HasPrecision(10, 2);

            modelBuilder.Entity<INFS>()
                .Property(e => e.reimp)
                .HasPrecision(10, 2);

            modelBuilder.Entity<interes>()
                .Property(e => e.interes1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<interes>()
                .Property(e => e.seguro)
                .HasPrecision(19, 4);

            modelBuilder.Entity<interes>()
                .Property(e => e.almacenaje)
                .HasPrecision(19, 4);

            modelBuilder.Entity<inventariopromocion>()
                .Property(e => e.precio)
                .HasPrecision(19, 4);

            modelBuilder.Entity<inventariopromocion>()
                .Property(e => e.precioxcanje)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Niveles_acceso>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Noticias_SEMP2013>()
                .Property(e => e.noticia)
                .IsUnicode(false);

            modelBuilder.Entity<PRG11>()
                .Property(e => e.Debe)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PRG11>()
                .Property(e => e.Haber)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PRG11>()
                .Property(e => e.Saldo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PRG11>()
                .Property(e => e.Comentario)
                .IsUnicode(false);

            modelBuilder.Entity<PRG12>()
                .Property(e => e.Debe)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PRG12>()
                .Property(e => e.Haber)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PRG12>()
                .Property(e => e.Saldo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PRG12>()
                .Property(e => e.Comentario)
                .IsUnicode(false);

            modelBuilder.Entity<prom_aplica>()
                .Property(e => e.activado)
                .IsFixedLength();

            modelBuilder.Entity<prom_aumento>()
                .Property(e => e.prestamo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prom_aumento>()
                .Property(e => e.activado)
                .IsFixedLength();

            modelBuilder.Entity<prom_descuento_interes>()
                .Property(e => e.prestamo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prom_descuento_interes>()
                .Property(e => e.activado)
                .IsFixedLength();

            modelBuilder.Entity<prom_ventas>()
                .Property(e => e.venta)
                .HasPrecision(19, 4);

            modelBuilder.Entity<prom_ventas>()
                .Property(e => e.activado)
                .IsFixedLength();

            modelBuilder.Entity<promocioncaja>()
                .Property(e => e.importe)
                .HasPrecision(19, 4);

            modelBuilder.Entity<promocioncaja>()
                .Property(e => e.valor_prenda)
                .HasPrecision(19, 4);

            modelBuilder.Entity<promociones>()
                .Property(e => e.anterior)
                .HasPrecision(19, 4);

            modelBuilder.Entity<promociones>()
                .Property(e => e.nuevo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<promociones_Activas>()
                .Property(e => e.activa)
                .IsFixedLength();

            modelBuilder.Entity<promociones_Activas>()
                .Property(e => e.descuento_porciento)
                .HasPrecision(18, 0);

            modelBuilder.Entity<promociones_Activas>()
                .Property(e => e.descuento_cantidad)
                .HasPrecision(19, 4);

            modelBuilder.Entity<promociones_Activas>()
                .Property(e => e.compra_mayor_a)
                .HasPrecision(19, 4);

            modelBuilder.Entity<promocionesregalo>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<puntos_confg>()
                .Property(e => e.cantidad_C)
                .HasPrecision(19, 4);

            modelBuilder.Entity<puntos_confg>()
                .Property(e => e.cantidad_NP)
                .HasPrecision(19, 4);

            modelBuilder.Entity<puntos_confg>()
                .Property(e => e.valor_pts_C)
                .HasPrecision(18, 0);

            modelBuilder.Entity<puntos_confg>()
                .Property(e => e.valor_pts_NP)
                .HasPrecision(18, 0);

            modelBuilder.Entity<refrendo>()
                .Property(e => e.refrendo1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Reimpresiones>()
                .Property(e => e.costo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<remisiones>()
                .Property(e => e.Precio)
                .HasPrecision(19, 4);

            modelBuilder.Entity<remisiones>()
                .Property(e => e.Importe)
                .HasPrecision(19, 4);

            modelBuilder.Entity<remisiones>()
                .Property(e => e.comentarios)
                .IsUnicode(false);

            modelBuilder.Entity<Retiros>()
                .Property(e => e.cantidad)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Retiros>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Retiros>()
                .Property(e => e.motivo)
                .IsUnicode(false);

            modelBuilder.Entity<seguro>()
                .Property(e => e.seguro1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TEMP_AVALUO>()
                .Property(e => e.Valor_prenda)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TEMP_AVALUO>()
                .Property(e => e.Prestamo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TEMP_AVALUO>()
                .Property(e => e.A)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TEMP_AVALUO>()
                .Property(e => e.B)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TEMP_AVALUO2>()
                .Property(e => e.Valor_prenda)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TEMP_AVALUO2>()
                .Property(e => e.Detalles_de_prenda)
                .IsUnicode(false);

            modelBuilder.Entity<TEMP_AVALUO2>()
                .Property(e => e.Prestamo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TEMP_AVALUO2>()
                .Property(e => e.A)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TEMP_AVALUO2>()
                .Property(e => e.B)
                .HasPrecision(19, 4);

            modelBuilder.Entity<transferencias>()
                .Property(e => e.direccion)
                .IsUnicode(false);

            modelBuilder.Entity<transferencias>()
                .Property(e => e.direccion2)
                .IsUnicode(false);

            modelBuilder.Entity<transferencias>()
                .Property(e => e.comentarios)
                .IsUnicode(false);

            modelBuilder.Entity<transferencias>()
                .Property(e => e.observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<TRFENTRADA>()
                .Property(e => e.direccion)
                .IsUnicode(false);

            modelBuilder.Entity<TRFENTRADA>()
                .Property(e => e.direccion2)
                .IsUnicode(false);

            modelBuilder.Entity<TRFENTRADA>()
                .Property(e => e.comentarios)
                .IsUnicode(false);

            modelBuilder.Entity<TRFENTRADA>()
                .Property(e => e.observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<VALOR_FACTORES>()
                .Property(e => e.p1)
                .IsFixedLength();

            modelBuilder.Entity<VALOR_FACTORES>()
                .Property(e => e.p2)
                .IsFixedLength();

            modelBuilder.Entity<VALOR_FACTORES>()
                .Property(e => e.p3)
                .IsFixedLength();

            modelBuilder.Entity<VALOR_FACTORES>()
                .Property(e => e.p4)
                .IsFixedLength();

            modelBuilder.Entity<VALOR_FACTORES>()
                .Property(e => e.p5)
                .IsFixedLength();

            modelBuilder.Entity<VALOR_FACTORES>()
                .Property(e => e.p6)
                .IsFixedLength();

            modelBuilder.Entity<VALOR_FACTORES>()
                .Property(e => e.p7)
                .IsFixedLength();

            modelBuilder.Entity<VALOR_FACTORES>()
                .Property(e => e.ad1)
                .IsFixedLength();

            modelBuilder.Entity<VALOR_FACTORES>()
                .Property(e => e.ad2)
                .IsFixedLength();

            modelBuilder.Entity<VALOR_FACTORES>()
                .Property(e => e.ad3)
                .IsFixedLength();

            modelBuilder.Entity<VALOR_FACTORES>()
                .Property(e => e.ad4)
                .IsFixedLength();

            modelBuilder.Entity<VALOR_FACTORES>()
                .Property(e => e.ad5)
                .IsFixedLength();

            modelBuilder.Entity<VALOR_FACTORES>()
                .Property(e => e.ad6)
                .IsFixedLength();

            modelBuilder.Entity<VALOR_FACTORES>()
                .Property(e => e.ad7)
                .IsFixedLength();

            modelBuilder.Entity<vencidos>()
                .Property(e => e.SubDescripcion)
                .IsUnicode(false);

            modelBuilder.Entity<vencidos>()
                .Property(e => e.Avaluo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<vencidos>()
                .Property(e => e.Prestamo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<vencidos>()
                .Property(e => e.descripcion_ant)
                .IsUnicode(false);

            modelBuilder.Entity<vencidos>()
                .Property(e => e.subdescripcion_ant)
                .IsUnicode(false);

            modelBuilder.Entity<vencidos>()
                .Property(e => e.prestamo_ant)
                .HasPrecision(19, 4);

            modelBuilder.Entity<vencidos>()
                .Property(e => e.avaluo_ant)
                .HasPrecision(19, 4);

            modelBuilder.Entity<vencidos>()
                .Property(e => e.Precio_venta)
                .HasPrecision(19, 4);

            modelBuilder.Entity<vencidos>()
                .Property(e => e.Precio_remate)
                .HasPrecision(19, 4);
        }
    }
}
