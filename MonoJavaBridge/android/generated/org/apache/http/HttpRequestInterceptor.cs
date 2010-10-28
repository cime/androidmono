namespace org.apache.http
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.HttpRequestInterceptor_))]
	public partial interface HttpRequestInterceptor  : global::MonoJavaBridge.IJavaObject 
	{
		void process(org.apache.http.HttpRequest arg0, org.apache.http.protocol.HttpContext arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.HttpRequestInterceptor))]
	internal sealed partial class HttpRequestInterceptor_ : java.lang.Object, HttpRequestInterceptor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal HttpRequestInterceptor_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _process31637;
		void org.apache.http.HttpRequestInterceptor.process(org.apache.http.HttpRequest arg0, org.apache.http.protocol.HttpContext arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpRequestInterceptor_._process31637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpRequestInterceptor_.staticClass, global::org.apache.http.HttpRequestInterceptor_._process31637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static HttpRequestInterceptor_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.HttpRequestInterceptor_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/HttpRequestInterceptor"));
			global::org.apache.http.HttpRequestInterceptor_._process31637 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpRequestInterceptor_.staticClass, "process", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}