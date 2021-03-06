﻿using luis_beuth_mobile.Models.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using luis_beuthluis_beuth_mobile.Models.Data;

namespace luis_beuth_mobile.Model
{
    class RestExams : IREST<Exam>
    {
        public async Task<List<Exam>> Get()
        {
            var http = new HttpClient();
            string url = "http://luis-beuth.azurewebsites.net/api/exam";
            var response = await http.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var exams= stringToExam(content);
                return exams;
            }
            else { return null; }

        }


        public async Task<List<Rent>> GetAllRentedExams(int studentId)
        {
            var httpClient = new HttpClient();

            string urlRents = "http://luis-beuth.azurewebsites.net/api/rent?studentId=" + studentId;

            var response = await httpClient.GetAsync(urlRents);
  
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                Debug.WriteLine("DEBUG_CONTENT: " + content);
                var rents = stringToRent(content);
                return rents;
            }
            else { return null; }
        }

        public Task<Exam> GetById(int id)
        {
            return null;
        }

        private List<Exam> stringToExam(string json)
        {
            return JsonConvert.DeserializeObject<List<Exam>>(json);
        }

        private List<Rent> stringToRent(string json)
        {
            return JsonConvert.DeserializeObject<List<Rent>>(json);
        }
    }
}
