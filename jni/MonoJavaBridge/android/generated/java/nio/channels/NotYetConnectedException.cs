namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NotYetConnectedException : java.lang.IllegalStateException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static NotYetConnectedException()
		{
			InitJNI();
		}
		protected NotYetConnectedException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _NotYetConnectedException16805;
		public NotYetConnectedException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.NotYetConnectedException.staticClass, global::java.nio.channels.NotYetConnectedException._NotYetConnectedException16805);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.NotYetConnectedException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/NotYetConnectedException"));
			global::java.nio.channels.NotYetConnectedException._NotYetConnectedException16805 = @__env.GetMethodIDNoThrow(global::java.nio.channels.NotYetConnectedException.staticClass, "<init>", "()V");
		}
	}
}
