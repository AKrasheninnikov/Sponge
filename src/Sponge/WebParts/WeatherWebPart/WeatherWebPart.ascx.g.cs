﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5472
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sponge.WebParts {
    using System.Web.Profile;
    using System.Text.RegularExpressions;
    using System.Web.Caching;
    using System.Configuration;
    using System.Web.Security;
    using Microsoft.SharePoint;
    using System.Web.UI.HtmlControls;
    using System.Web;
    using System.Web.UI.WebControls;
    using System.Web.UI;
    using System.Collections;
    using System;
    using System.Collections.Specialized;
    using System.Web.UI.WebControls.WebParts;
    using System.Web.SessionState;
    using System.Text;
    
    
    public partial class WeatherWebPart {
        
        public static implicit operator global::System.Web.UI.TemplateControl(WeatherWebPart target) 
        {
            return target == null ? null : target.TemplateControl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void @__BuildControlTree(global::Sponge.WebParts.WeatherWebPart @__ctrl) {
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n\r\n<script src=\"_layouts/Sponge/scripts/jquery-1.7.2.min.js\" type=\"text/javascri" +
                        "pt\"></script>\r\n<link type=\"text/css\" rel=\"stylesheet\" href=\"_layouts/Sponge/styl" +
                        "es/sponge.webparts.weather.css\" />\r\n\r\n<div id=\"weather\" class=\"weatherFeed\"></di" +
                        "v>\r\n\r\n<script type=\"text/javascript\">\r\n    $(document).ready(function() {\r\n     " +
                        "   $.getScript(\"_layouts/Sponge/scripts/jquery.geolocation.js\", function() {\r\n  " +
                        "          $.geolocation.get({\r\n                win: function(position) {\r\n      " +
                        "              var lat = position.coords.latitude;\r\n                    var lon =" +
                        " position.coords.longitude;\r\n\r\n                    var now = new Date();\r\n      " +
                        "              var query = \"select woeid from geo.placefinder where text=\'\" + lat" +
                        " + \",\" + lon + \"\' and gflags=\'R\'\";\r\n                    var api = \'http://query." +
                        "yahooapis.com/v1/public/yql?q=\' + encodeURIComponent(query) + \'&rnd=\' + now.getF" +
                        "ullYear() + now.getMonth() + now.getDay() + now.getHours() + \'&format=json&callb" +
                        "ack=?\';\r\n\r\n                    $.getJSON(api, function(data) {\r\n\r\n              " +
                        "          var result = $.parseJSON(JSON.stringify(data));\r\n\r\n                   " +
                        "     var woeid = result.query.results.Result.woeid;\r\n                        loa" +
                        "dWeatherWidget(woeid);\r\n                    });\r\n                },\r\n           " +
                        "     fail: function() {\r\n                    $(\"#weather\").append(\"<p>Your curre" +
                        "nt browser does not support HTML geo-locations or you did not enable them. Pleas" +
                        "e update to a modern browser.</p>\");\r\n                }\r\n            });\r\n      " +
                        "  });\r\n        \r\n        function loadWeatherWidget(woeid) {\r\n            $.getS" +
                        "cript(\"_layouts/Sponge/scripts/jquery.zweatherfeed.min.js\", function () {\r\n     " +
                        "           $(\'#weather\').weatherfeed([woeid], {\r\n                    woeid: true" +
                        "\r\n                });\r\n            });\r\n        }\r\n    });\r\n</script>\r\n"));
        }
        
        private void InitializeControl() {
            this.@__BuildControlTree(this);
            this.Load += new global::System.EventHandler(this.Page_Load);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected virtual object Eval(string expression) {
            return global::System.Web.UI.DataBinder.Eval(this.Page.GetDataItem(), expression);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected virtual string Eval(string expression, string format) {
            return global::System.Web.UI.DataBinder.Eval(this.Page.GetDataItem(), expression, format);
        }
    }
}
