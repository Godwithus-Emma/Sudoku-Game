using Microsoft.Extensions.DependencyInjection;
using Sudoku.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku.Core
{
    public static class Startup
    {
        public static void AddSudoku(this IServiceCollection services)
        {
            services.AddScoped<GameDatabase>();
            services.AddScoped<SudokuEngine>();
        }
    }
}
