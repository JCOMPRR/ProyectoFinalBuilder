// See https://aka.ms/new-console-template for more information
using ProyectoFinalBuilder;

ReporteVentas reporte = new ReporteVentas();

reporte.AgregarTitulo("Reporte de Ventas");
reporte.AgregarFecha(System.DateTime.Now);
reporte.AgregarProductos("Monster", 10, 34);
reporte.AgregarProductos("Cafe", 5, 15);

Console.WriteLine(reporte.GetReporte());

