namespace org.apache.http.auth
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AuthenticationException : org.apache.http.ProtocolException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AuthenticationException()
		{
			InitJNI();
		}
		protected AuthenticationException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _AuthenticationException25155;
		public AuthenticationException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.AuthenticationException.staticClass, global::org.apache.http.auth.AuthenticationException._AuthenticationException25155);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AuthenticationException25156;
		public AuthenticationException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.AuthenticationException.staticClass, global::org.apache.http.auth.AuthenticationException._AuthenticationException25156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AuthenticationException25157;
		public AuthenticationException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.AuthenticationException.staticClass, global::org.apache.http.auth.AuthenticationException._AuthenticationException25157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.auth.AuthenticationException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/auth/AuthenticationException"));
			global::org.apache.http.auth.AuthenticationException._AuthenticationException25155 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthenticationException.staticClass, "<init>", "()V");
			global::org.apache.http.auth.AuthenticationException._AuthenticationException25156 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthenticationException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::org.apache.http.auth.AuthenticationException._AuthenticationException25157 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthenticationException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
		}
	}
}
