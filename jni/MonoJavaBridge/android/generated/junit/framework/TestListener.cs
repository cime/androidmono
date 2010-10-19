namespace junit.framework
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::junit.framework.TestListener_))]
	public interface TestListener  : global::MonoJavaBridge.IJavaObject 
	{
		void addError(junit.framework.Test arg0, java.lang.Throwable arg1);
		void addFailure(junit.framework.Test arg0, junit.framework.AssertionFailedError arg1);
		void endTest(junit.framework.Test arg0);
		void startTest(junit.framework.Test arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::junit.framework.TestListener))]
	public sealed partial class TestListener_ : java.lang.Object, TestListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TestListener_()
		{
			InitJNI();
		}
		internal TestListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _addError24790;
		 void junit.framework.TestListener.addError(junit.framework.Test arg0, java.lang.Throwable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.framework.TestListener_._addError24790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.framework.TestListener_.staticClass, global::junit.framework.TestListener_._addError24790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addFailure24791;
		 void junit.framework.TestListener.addFailure(junit.framework.Test arg0, junit.framework.AssertionFailedError arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.framework.TestListener_._addFailure24791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.framework.TestListener_.staticClass, global::junit.framework.TestListener_._addFailure24791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _endTest24792;
		 void junit.framework.TestListener.endTest(junit.framework.Test arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.framework.TestListener_._endTest24792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.framework.TestListener_.staticClass, global::junit.framework.TestListener_._endTest24792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startTest24793;
		 void junit.framework.TestListener.startTest(junit.framework.Test arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.framework.TestListener_._startTest24793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.framework.TestListener_.staticClass, global::junit.framework.TestListener_._startTest24793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::junit.framework.TestListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("junit/framework/TestListener"));
			global::junit.framework.TestListener_._addError24790 = @__env.GetMethodIDNoThrow(global::junit.framework.TestListener_.staticClass, "addError", "(Ljunit/framework/Test;Ljava/lang/Throwable;)V");
			global::junit.framework.TestListener_._addFailure24791 = @__env.GetMethodIDNoThrow(global::junit.framework.TestListener_.staticClass, "addFailure", "(Ljunit/framework/Test;Ljunit/framework/AssertionFailedError;)V");
			global::junit.framework.TestListener_._endTest24792 = @__env.GetMethodIDNoThrow(global::junit.framework.TestListener_.staticClass, "endTest", "(Ljunit/framework/Test;)V");
			global::junit.framework.TestListener_._startTest24793 = @__env.GetMethodIDNoThrow(global::junit.framework.TestListener_.staticClass, "startTest", "(Ljunit/framework/Test;)V");
		}
	}
}
