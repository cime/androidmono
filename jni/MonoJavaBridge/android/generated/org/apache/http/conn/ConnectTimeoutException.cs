namespace org.apache.http.conn
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ConnectTimeoutException : java.io.InterruptedIOException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ConnectTimeoutException()
		{
			InitJNI();
		}
		protected ConnectTimeoutException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _ConnectTimeoutException25387;
		public ConnectTimeoutException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.ConnectTimeoutException.staticClass, global::org.apache.http.conn.ConnectTimeoutException._ConnectTimeoutException25387);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ConnectTimeoutException25388;
		public ConnectTimeoutException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.ConnectTimeoutException.staticClass, global::org.apache.http.conn.ConnectTimeoutException._ConnectTimeoutException25388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.ConnectTimeoutException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/ConnectTimeoutException"));
			global::org.apache.http.conn.ConnectTimeoutException._ConnectTimeoutException25387 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ConnectTimeoutException.staticClass, "<init>", "()V");
			global::org.apache.http.conn.ConnectTimeoutException._ConnectTimeoutException25388 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.ConnectTimeoutException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
