﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SlideRoom
{
    public class SlideRoomAPIException : Exception
    {
        public HttpStatusCode? StatusCode { get; private set; }

        public SlideRoomAPIException(string message, HttpStatusCode? code = null)
            : base(message)
        {
            StatusCode = code;
        }
    }

    public class SlideRoomAPIExceptionResponse
    {

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}