using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using TareaWCF.DTO;
using Dapper;
using TareaWCF.BLL;

namespace TareaWCF.DAL
{
    public class EmployeeDO
    {
        public EmployeeDTO Bind(Employee employee)
        {
            EmployeeDTO employeeResult = new EmployeeDTO();
            employeeResult.Id = employee.EmployeeID;
            employeeResult.Name = employee.EmployeeName;
            employeeResult.Email = employee.Email;
            employeeResult.Age = employee.Age;
            return employeeResult;
        }

        public List<Employee> BindList(List<EmployeeDTO> employeeList)
        {
            List<Employee> result = new List<Employee>();
            employeeList.ForEach(x =>
            {
                Employee employee = new Employee();
                employee.EmployeeID = x.Id;
                employee.EmployeeName = x.Name;
                employee.Email = x.Email;
                employee.Age = x.Age;
                result.Add(employee);
            });

            return result;
        }

        public DataTable BindTable(Employee[] employeeList)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Email", typeof(string));
            dt.Columns.Add("Age", typeof(int));

            DataRow dr;

            //employeeList.ForEach(x =>
            //{
            //    dr = dt.NewRow();

            //    dr["EmployeeName"] = x.EmployeeName;
            //    dr["Email"] = x.Email;
            //    dr["Age"] = x.Age;

            //    dt.Rows.Add(dr);
            //});

            foreach (var employee in employeeList)
            {
                dr = dt.NewRow();

                dr["Name"] = employee.EmployeeName;
                dr["Email"] = employee.Email;
                dr["Age"] = employee.Age;

                dt.Rows.Add(dr);
            }

            return dt;
        }

        public async Task<bool> Save(Employee employee)
        {
            bool result = false;
            try
            {
                EmployeeDTO employeeSave = Bind(employee);
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeesBD"].ConnectionString))
                {
                    connection.Open();
                    await connection.ExecuteAsync("PuntoDeVenta.spEmployeeSave", employeeSave, commandType: CommandType.StoredProcedure);
                    result = true;
                }

            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }

        public async Task<List<Employee>> GetAll()
        {
            List<Employee> result = new List<Employee>();
            try
            {

                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeesBD"].ConnectionString))
                {
                    connection.Open();
                    var x = await connection.QueryAsync<EmployeeDTO>("PuntoDeVenta.spEmployeeGetList", commandType: CommandType.StoredProcedure);
                    result = BindList(x.ToList());
                }

            }
            catch (Exception ex)
            {

            }

            return result;
        }

        public async Task<bool> Delete(int id)
        {
            bool result = false;
            try
            {
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeesBD"].ConnectionString))
                {
                    connection.Open();
                    await connection.ExecuteAsync("PuntoDeVenta.spEmployeeDelete", new { Id=  id }, commandType: CommandType.StoredProcedure);
                    result = true;
                }

            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }

        public async Task<bool> Update(Employee employee)
        {
            bool result = false;
            try
            {
                EmployeeDTO employeeEdit = Bind(employee);
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeesBD"].ConnectionString))
                {
                    connection.Open();
                    await connection.ExecuteAsync("PuntoDeVenta.spEmployeeEdit", employeeEdit, commandType: CommandType.StoredProcedure);
                    result = true;
                }

            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }

        public async Task<bool> SaveMasive(Employee[] employee)
        {
            bool result = false;
            try
            {
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeesBD"].ConnectionString))
                {
                    SqlCommand command = new SqlCommand("[PuntoDeVenta].[spEmployeeSaveMasive]", connection);
                    command.CommandType = CommandType.StoredProcedure;
                        
                    DataTable dt = BindTable(employee);
                    
                    SqlParameter parameter = new SqlParameter();
                    parameter.ParameterName = "dtEmployees";
                    parameter.Value = dt;

                    command.Parameters.Add(parameter);

                    connection.Open();
                    await command.ExecuteNonQueryAsync();
                   // await connection.ExecuteAsync("PuntoDeVenta.spEmployeeSaveMasive", parameter, commandType: CommandType.StoredProcedure);
                    result = true;
                }

            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }

    }
}