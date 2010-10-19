namespace org.apache.http.client.@params
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HttpClientParams : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpClientParams()
		{
			InitJNI();
		}
		protected HttpClientParams(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setCookiePolicy25326;
		public static void setCookiePolicy(org.apache.http.@params.HttpParams arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(org.apache.http.client.@params.HttpClientParams.staticClass, global::org.apache.http.client.@params.HttpClientParams._setCookiePolicy25326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isRedirecting25327;
		public static bool isRedirecting(org.apache.http.@params.HttpParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(org.apache.http.client.@params.HttpClientParams.staticClass, global::org.apache.http.client.@params.HttpClientParams._isRedirecting25327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setRedirecting25328;
		public static void setRedirecting(org.apache.http.@params.HttpParams arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(org.apache.http.client.@params.HttpClientParams.staticClass, global::org.apache.http.client.@params.HttpClientParams._setRedirecting25328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isAuthenticating25329;
		public static bool isAuthenticating(org.apache.http.@params.HttpParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(org.apache.http.client.@params.HttpClientParams.staticClass, global::org.apache.http.client.@params.HttpClientParams._isAuthenticating25329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAuthenticating25330;
		public static void setAuthenticating(org.apache.http.@params.HttpParams arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(org.apache.http.client.@params.HttpClientParams.staticClass, global::org.apache.http.client.@params.HttpClientParams._setAuthenticating25330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getCookiePolicy25331;
		public static global::java.lang.String getCookiePolicy(org.apache.http.@params.HttpParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.apache.http.client.@params.HttpClientParams.staticClass, global::org.apache.http.client.@params.HttpClientParams._getCookiePolicy25331, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.@params.HttpClientParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/@params/HttpClientParams"));
			global::org.apache.http.client.@params.HttpClientParams._setCookiePolicy25326 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.client.@params.HttpClientParams.staticClass, "setCookiePolicy", "(Lorg/apache/http/@params/HttpParams;Ljava/lang/String;)V");
			global::org.apache.http.client.@params.HttpClientParams._isRedirecting25327 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.client.@params.HttpClientParams.staticClass, "isRedirecting", "(Lorg/apache/http/@params/HttpParams;)Z");
			global::org.apache.http.client.@params.HttpClientParams._setRedirecting25328 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.client.@params.HttpClientParams.staticClass, "setRedirecting", "(Lorg/apache/http/@params/HttpParams;Z)V");
			global::org.apache.http.client.@params.HttpClientParams._isAuthenticating25329 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.client.@params.HttpClientParams.staticClass, "isAuthenticating", "(Lorg/apache/http/@params/HttpParams;)Z");
			global::org.apache.http.client.@params.HttpClientParams._setAuthenticating25330 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.client.@params.HttpClientParams.staticClass, "setAuthenticating", "(Lorg/apache/http/@params/HttpParams;Z)V");
			global::org.apache.http.client.@params.HttpClientParams._getCookiePolicy25331 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.client.@params.HttpClientParams.staticClass, "getCookiePolicy", "(Lorg/apache/http/@params/HttpParams;)Ljava/lang/String;");
		}
	}
}
