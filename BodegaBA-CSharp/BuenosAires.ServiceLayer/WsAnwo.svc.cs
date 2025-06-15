using BuenosAires.Model;
using BuenosAires.Model.Utiles;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;

namespace BuenosAires.ServiceLayer
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "WsAnwo" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione WsAnwo.svc o WsAnwo.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class WsAnwo : IWsAnwo
    {
        public Respuesta Consultar_productos_disponibles()
        {
            Console.WriteLine("\n=== Iniciando Consultar_productos_disponibles ===");
            var resp = new Respuesta();
            resp.Accion = "Obtener equipos Anwo";
            resp.Mensaje = "";
            resp.HayErrores = false;

            string apiUrl = "http://127.0.0.1:5000/consultar_productos_disponibles";
            Console.WriteLine($"Llamando a API URL: {apiUrl}");

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    Console.WriteLine("Enviando solicitud GET...");
                    HttpResponseMessage response = client.GetAsync(apiUrl).Result;
                    Console.WriteLine($"Código de respuesta: {response.StatusCode}");

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonContent = response.Content.ReadAsStringAsync().Result;
                        Console.WriteLine($"JSON recibido: {jsonContent}");
                        resp.JsonListaStockAnwo = jsonContent;
                        Console.WriteLine("JSON almacenado en resp.JsonListaStockAnwo");
                    }
                    else
                    {
                        resp.HayErrores = true;
                        resp.Mensaje = "No fue Posible " + resp.Accion + ", intente nuevamente más tarde " +
                            "o comuniquese con el Administrador del Sistema";
                        Console.WriteLine($"Error en la llamada: {resp.Mensaje}");
                    }
                    return resp;
                }
            }
            catch (Exception ex)
            {
                resp.HayErrores = true;
                resp.Mensaje = Util.MensajeError(resp.Accion, "WsAnwo.Consultar_productos_disponibles", ex);
                Console.WriteLine($"Excepción: {ex.Message}");
                Console.WriteLine($"StackTrace: {ex.StackTrace}");
                return resp;
            }
        }

        public Respuesta reservar_equipo_anwo(string nroserieanwo, char charReservado)
        {
            Console.WriteLine("\n=== Iniciando reservar_equipo_anwo ===");
            Console.WriteLine($"Parámetros: nroserieanwo={nroserieanwo}, charReservado={charReservado}");

            var resp = new Respuesta();
            resp.Accion = "Reservar equipo Anwo: ";
            resp.Mensaje = "";
            resp.HayErrores = false;

            string apiUrl = "http://127.0.0.1:5000/reservar_equipo_anwo";
            Console.WriteLine($"Llamando a API URL: {apiUrl}");

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var json = $"{{ \"nroserieanwo\": \"{nroserieanwo}\", \"reservado\": \"{charReservado}\" }}";
                    Console.WriteLine($"JSON a enviar: {json}");

                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    Console.WriteLine("Enviando solicitud POST...");

                    HttpResponseMessage response = client.PostAsync(apiUrl, content).Result;
                    Console.WriteLine($"Código de respuesta: {response.StatusCode}");

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = response.Content.ReadAsStringAsync().Result;
                        Console.WriteLine($"JSON recibido: {jsonResponse}");
                        resp.JsonListaStockAnwo = jsonResponse;
                        resp.Mensaje = $"Se reservó el equipo {nroserieanwo}";
                        Console.WriteLine($"Mensaje de éxito: {resp.Mensaje}");
                    }
                    else
                    {
                        resp.HayErrores = true;
                        resp.Mensaje = "No fue posible " + resp.Accion + nroserieanwo +
                                     ", intente nuevamente más tarde o comuníquese con el Administrador del Sistema";
                        Console.WriteLine($"Error en la llamada: {resp.Mensaje}");
                    }

                    return resp;
                }
            }
            catch (Exception ex)
            {
                resp.HayErrores = true;
                resp.Mensaje = Util.MensajeError(resp.Accion, "WsAnwo.reservar_equipo_anwo", ex);
                Console.WriteLine($"Excepción: {ex.Message}");
                Console.WriteLine($"StackTrace: {ex.StackTrace}");
                return resp;
            }
        }
    }
}
