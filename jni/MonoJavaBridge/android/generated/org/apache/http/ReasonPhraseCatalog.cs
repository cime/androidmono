namespace org.apache.http
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.ReasonPhraseCatalog_))]
	public interface ReasonPhraseCatalog  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.String getReason(int arg0, java.util.Locale arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.ReasonPhraseCatalog))]
	public sealed partial class ReasonPhraseCatalog_ : java.lang.Object, ReasonPhraseCatalog
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ReasonPhraseCatalog_()
		{
			InitJNI();
		}
		internal ReasonPhraseCatalog_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getReason25101;
		 global::java.lang.String org.apache.http.ReasonPhraseCatalog.getReason(int arg0, java.util.Locale arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.ReasonPhraseCatalog_._getReason25101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.ReasonPhraseCatalog_.staticClass, global::org.apache.http.ReasonPhraseCatalog_._getReason25101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.ReasonPhraseCatalog_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/ReasonPhraseCatalog"));
			global::org.apache.http.ReasonPhraseCatalog_._getReason25101 = @__env.GetMethodIDNoThrow(global::org.apache.http.ReasonPhraseCatalog_.staticClass, "getReason", "(ILjava/util/Locale;)Ljava/lang/String;");
		}
	}
}
