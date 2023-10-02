using Ejemplo1.Models;
using Ejemplo1.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.Data;


namespace Ejemplo1.Controllers
{
    public class ProductoController : Controller
    {
        // GET: ProductoController1
        public ActionResult Index()
        {
            List<Producto> listaProductos = Utils.Utils.ListaProductos; //Se llama a la lista sin productos
            DataTable dataTble= ConvertirListaToDataTable<Producto>(listaProductos);

            return View(dataTble);
        }

        public DataTable ConvertirListaToDataTable<T>(IList<T> data)
        {

            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));

            DataTable table = new DataTable();

            foreach (PropertyDescriptor prop in properties) table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);

            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties) row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }

        // GET: ProductoController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductoController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductoController1/Create}

        // GET: ProductoController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // GET: ProductoController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductoController1/Delete/5
    }
}
