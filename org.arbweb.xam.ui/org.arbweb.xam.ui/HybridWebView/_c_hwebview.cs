using System;
using Xamarin.Forms;

namespace org.arbweb.xam.ui
{
    public class _c_hybridwebview : WebView
    {
        Action<string> action;

        public static readonly BindableProperty UriProperty = BindableProperty.Create(
            propertyName: "Uri",
            returnType: typeof(string),
            declaringType: typeof(_c_hybridwebview),
            defaultValue: default(string));

        /// <summary>
        /// Gets or sets uri : (html/home.html")
        /// </summary>
        public string Uri
        {
            get { return (string)GetValue(UriProperty); }
            set { SetValue(UriProperty, value); }
        }

        /// <summary>
        /// Assign C# action with 1 string parameter to call from JS
        /// </summary>
        /// <param name="callback"></param>
        public void RegisterAction(Action<string> callback)
        {
            action = callback;
        }

        /// <summary>
        /// Remove the C# action assigned
        /// </summary>
        public void Cleanup()
        {
            action = null;
        }

        public void InvokeAction(string data)
        {
            if (action == null || data == null)
            {
                return;
            }
            action.Invoke(data);
        }
    }
}