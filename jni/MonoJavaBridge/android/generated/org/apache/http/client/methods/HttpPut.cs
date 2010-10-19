namespace org.apache.http.client.methods
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HttpPut : org.apache.http.client.methods.HttpEntityEnclosingRequestBase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpPut()
		{
			InitJNI();
		}
		protected HttpPut(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String Method
		{
			get
			{
				return getMethod();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMethod25272;
		public override global::java.lang.String getMethod() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpPut._getMethod25272)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpPut.staticClass, global::org.apache.http.client.methods.HttpPut._getMethod25272)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _HttpPut25273;
		public HttpPut()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.methods.HttpPut.staticClass, global::org.apache.http.client.methods.HttpPut._HttpPut25273);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HttpPut25274;
		public HttpPut(java.net.URI arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.methods.HttpPut.staticClass, global::org.apache.http.client.methods.HttpPut._HttpPut25274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HttpPut25275;
		public HttpPut(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.methods.HttpPut.staticClass, global::org.apache.http.client.methods.HttpPut._HttpPut25275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static global::java.lang.String METHOD_NAME
		{
			get
			{
				return "PUT";
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.methods.HttpPut.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/methods/HttpPut"));
			global::org.apache.http.client.methods.HttpPut._getMethod25272 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpPut.staticClass, "getMethod", "()Ljava/lang/String;");
			global::org.apache.http.client.methods.HttpPut._HttpPut25273 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpPut.staticClass, "<init>", "()V");
			global::org.apache.http.client.methods.HttpPut._HttpPut25274 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpPut.staticClass, "<init>", "(Ljava/net/URI;)V");
			global::org.apache.http.client.methods.HttpPut._HttpPut25275 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpPut.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
