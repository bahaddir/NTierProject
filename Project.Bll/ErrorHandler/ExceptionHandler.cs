using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Bll.ErrorHandler
{
    public static class ExceptionHandler
    {

        // async metotlar
        public static async Task ExecuteAsync(Func<Task> fun)
        {
            try
            {
                await fun();
            }
            catch (Exception ex)
            {
                throw new Exception($"error occured {ex.Message}", ex);
            }
        }


        public static async Task<T> ExecuteAsync<T>(Func<Task<T>> fun)
        {
            try
            {
                return await fun();
            }
            catch (Exception ex)
            {
                throw new Exception($"error occured {ex.Message}", ex);
            }
        }
        // sync metotlar 
        public static T Execute<T>(Func<T> fun)
        {
            try
            {
                return fun();
            }
            catch (Exception ex)
            {
                throw new Exception($"error occured {ex.Message}", ex);
            }
        }
        public static void Execute(Action act)
        {
            try
            {
                act();
            }
            catch (Exception ex)
            {
                throw new Exception($"error occured {ex.Message}", ex);
            }
        }

        
    }

}
