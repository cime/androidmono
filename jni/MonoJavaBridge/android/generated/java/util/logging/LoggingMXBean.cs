namespace java.util.logging
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.logging.LoggingMXBean_))]
	public interface LoggingMXBean  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.util.List getLoggerNames();
		global::java.lang.String getLoggerLevel(java.lang.String arg0);
		void setLoggerLevel(java.lang.String arg0, java.lang.String arg1);
		global::java.lang.String getParentLoggerName(java.lang.String arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.logging.LoggingMXBean))]
	public sealed partial class LoggingMXBean_ : java.lang.Object, LoggingMXBean
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LoggingMXBean_()
		{
			InitJNI();
		}
		internal LoggingMXBean_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getLoggerNames22102;
		 global::java.util.List java.util.logging.LoggingMXBean.getLoggerNames() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.LoggingMXBean_._getLoggerNames22102)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.LoggingMXBean_.staticClass, global::java.util.logging.LoggingMXBean_._getLoggerNames22102)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getLoggerLevel22103;
		 global::java.lang.String java.util.logging.LoggingMXBean.getLoggerLevel(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.LoggingMXBean_._getLoggerLevel22103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.LoggingMXBean_.staticClass, global::java.util.logging.LoggingMXBean_._getLoggerLevel22103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setLoggerLevel22104;
		 void java.util.logging.LoggingMXBean.setLoggerLevel(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.LoggingMXBean_._setLoggerLevel22104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.LoggingMXBean_.staticClass, global::java.util.logging.LoggingMXBean_._setLoggerLevel22104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getParentLoggerName22105;
		 global::java.lang.String java.util.logging.LoggingMXBean.getParentLoggerName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.LoggingMXBean_._getParentLoggerName22105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.LoggingMXBean_.staticClass, global::java.util.logging.LoggingMXBean_._getParentLoggerName22105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.logging.LoggingMXBean_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/logging/LoggingMXBean"));
			global::java.util.logging.LoggingMXBean_._getLoggerNames22102 = @__env.GetMethodIDNoThrow(global::java.util.logging.LoggingMXBean_.staticClass, "getLoggerNames", "()Ljava/util/List;");
			global::java.util.logging.LoggingMXBean_._getLoggerLevel22103 = @__env.GetMethodIDNoThrow(global::java.util.logging.LoggingMXBean_.staticClass, "getLoggerLevel", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.util.logging.LoggingMXBean_._setLoggerLevel22104 = @__env.GetMethodIDNoThrow(global::java.util.logging.LoggingMXBean_.staticClass, "setLoggerLevel", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.util.logging.LoggingMXBean_._getParentLoggerName22105 = @__env.GetMethodIDNoThrow(global::java.util.logging.LoggingMXBean_.staticClass, "getParentLoggerName", "(Ljava/lang/String;)Ljava/lang/String;");
		}
	}
}
