namespace org.apache.http.message
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicHttpRequest : org.apache.http.message.AbstractHttpMessage, HttpRequest
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BasicHttpRequest()
		{
			InitJNI();
		}
		protected BasicHttpRequest(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::org.apache.http.ProtocolVersion ProtocolVersion
		{
			get
			{
				return getProtocolVersion();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProtocolVersion26826;
		public override global::org.apache.http.ProtocolVersion getProtocolVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHttpRequest._getProtocolVersion26826)) as org.apache.http.ProtocolVersion;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHttpRequest.staticClass, global::org.apache.http.message.BasicHttpRequest._getProtocolVersion26826)) as org.apache.http.ProtocolVersion;
		}
		public new global::org.apache.http.RequestLine RequestLine
		{
			get
			{
				return getRequestLine();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRequestLine26827;
		public virtual global::org.apache.http.RequestLine getRequestLine() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.RequestLine>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHttpRequest._getRequestLine26827)) as org.apache.http.RequestLine;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.RequestLine>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHttpRequest.staticClass, global::org.apache.http.message.BasicHttpRequest._getRequestLine26827)) as org.apache.http.RequestLine;
		}
		internal static global::MonoJavaBridge.MethodId _BasicHttpRequest26828;
		public BasicHttpRequest(java.lang.String arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicHttpRequest.staticClass, global::org.apache.http.message.BasicHttpRequest._BasicHttpRequest26828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BasicHttpRequest26829;
		public BasicHttpRequest(java.lang.String arg0, java.lang.String arg1, org.apache.http.ProtocolVersion arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicHttpRequest.staticClass, global::org.apache.http.message.BasicHttpRequest._BasicHttpRequest26829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BasicHttpRequest26830;
		public BasicHttpRequest(org.apache.http.RequestLine arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicHttpRequest.staticClass, global::org.apache.http.message.BasicHttpRequest._BasicHttpRequest26830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.BasicHttpRequest.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/BasicHttpRequest"));
			global::org.apache.http.message.BasicHttpRequest._getProtocolVersion26826 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHttpRequest.staticClass, "getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;");
			global::org.apache.http.message.BasicHttpRequest._getRequestLine26827 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHttpRequest.staticClass, "getRequestLine", "()Lorg/apache/http/RequestLine;");
			global::org.apache.http.message.BasicHttpRequest._BasicHttpRequest26828 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHttpRequest.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.apache.http.message.BasicHttpRequest._BasicHttpRequest26829 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHttpRequest.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Lorg/apache/http/ProtocolVersion;)V");
			global::org.apache.http.message.BasicHttpRequest._BasicHttpRequest26830 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHttpRequest.staticClass, "<init>", "(Lorg/apache/http/RequestLine;)V");
		}
	}
}
