using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using Parcell.Client.Shared;
using Parcell.Shared.Models;

namespace Parcell.Client.Pages.Sell.AddProducts
{
    public class AddProductModalBase : ComponentBase
    {
        [Inject]
        HttpClient Http { get; set; }

        [Inject]
        ILogger<ProductCreation> Logger { get; set; }

        protected ProductCreation newproduct = new();

        protected CustomFormValidator customFormValidator;

        protected bool isCreationSuccess = false;


        protected async Task AddProduct()
        {
            customFormValidator.ClearFormErrors();
            isCreationSuccess = false;

            Console.WriteLine("Checking product details");
            try
            {
                var response = await Http.PostAsJsonAsync("api/products", newproduct);
                var errors = await response.Content.ReadFromJsonAsync<Dictionary<string, List<string>>>();

                if (response.StatusCode == HttpStatusCode.BadRequest && errors.Count > 0)
                {
                    customFormValidator.DisplayFormErrors(errors);
                    throw new HttpRequestException($"Validation failed. Status Code: {response.StatusCode}");
                }
                else
                {
                    isCreationSuccess = true;
                    Logger.LogInformation("The product creation is successful");
                    Console.WriteLine("Product has been created");

                }

            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
            }
        }
    }
}