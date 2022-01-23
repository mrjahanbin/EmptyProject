﻿// See https://aka.ms/new-console-template for more information
using System.Net;
using System.Text;

string userIP = "46.209.96.26";
string apiKey = "5d3d0cdbc95df34b9db4a7b4fb754e738bce4ac914ca8909ace8d3ece39cee3b";
string url = "http://api.ipinfodb.com/v3/ip-country/?key=" + apiKey + "&ip=" + userIP;

WebRequest request = WebRequest.Create(url);

using (var response = (HttpWebResponse)request.GetResponse())
{
    // We try to use the "correct" charset
    Encoding encoding = response.CharacterSet != null ? Encoding.GetEncoding(response.CharacterSet) : null;

    using (var sr = encoding != null ? new StreamReader(response.GetResponseStream(), encoding) :
                                       new StreamReader(response.GetResponseStream(), true))
    {
        var response2 = sr.ReadToEnd();
        var parts = response2.Split(';');

        if (parts.Length != 5)
        {
            throw new Exception();
        }

        string okError = parts[0];
        string message = parts[1];
        string ip = parts[2];
        string code = parts[3];
        string country = parts[4];
    }
}
Console.WriteLine("Hello, World!");