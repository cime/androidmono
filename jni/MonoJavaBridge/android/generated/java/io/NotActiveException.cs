namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NotActiveException : java.io.ObjectStreamException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static NotActiveException()
		{
			InitJNI();
		}
		protected NotActiveException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _NotActiveException13548;
		public NotActiveException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.NotActiveException.staticClass, global::java.io.NotActiveException._NotActiveException13548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _NotActiveException13549;
		public NotActiveException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.NotActiveException.staticClass, global::java.io.NotActiveException._NotActiveException13549);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.NotActiveException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/NotActiveException"));
			global::java.io.NotActiveException._NotActiveException13548 = @__env.GetMethodIDNoThrow(global::java.io.NotActiveException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.io.NotActiveException._NotActiveException13549 = @__env.GetMethodIDNoThrow(global::java.io.NotActiveException.staticClass, "<init>", "()V");
		}
	}
}
