namespace java.util
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.TimerTask_))]
	public abstract partial class TimerTask : java.lang.Object, java.lang.Runnable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TimerTask()
		{
			InitJNI();
		}
		protected TimerTask(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _run20925;
		public abstract void run();
		internal static global::MonoJavaBridge.MethodId _cancel20926;
		public virtual bool cancel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.TimerTask._cancel20926);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.TimerTask.staticClass, global::java.util.TimerTask._cancel20926);
		}
		internal static global::MonoJavaBridge.MethodId _scheduledExecutionTime20927;
		public virtual long scheduledExecutionTime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.TimerTask._scheduledExecutionTime20927);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.TimerTask.staticClass, global::java.util.TimerTask._scheduledExecutionTime20927);
		}
		internal static global::MonoJavaBridge.MethodId _TimerTask20928;
		protected TimerTask()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.TimerTask.staticClass, global::java.util.TimerTask._TimerTask20928);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.TimerTask.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/TimerTask"));
			global::java.util.TimerTask._run20925 = @__env.GetMethodIDNoThrow(global::java.util.TimerTask.staticClass, "run", "()V");
			global::java.util.TimerTask._cancel20926 = @__env.GetMethodIDNoThrow(global::java.util.TimerTask.staticClass, "cancel", "()Z");
			global::java.util.TimerTask._scheduledExecutionTime20927 = @__env.GetMethodIDNoThrow(global::java.util.TimerTask.staticClass, "scheduledExecutionTime", "()J");
			global::java.util.TimerTask._TimerTask20928 = @__env.GetMethodIDNoThrow(global::java.util.TimerTask.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.TimerTask))]
	public sealed partial class TimerTask_ : java.util.TimerTask
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TimerTask_()
		{
			InitJNI();
		}
		internal TimerTask_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _run20929;
		public override void run() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.TimerTask_._run20929);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.TimerTask_.staticClass, global::java.util.TimerTask_._run20929);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.TimerTask_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/TimerTask"));
			global::java.util.TimerTask_._run20929 = @__env.GetMethodIDNoThrow(global::java.util.TimerTask_.staticClass, "run", "()V");
		}
	}
}
