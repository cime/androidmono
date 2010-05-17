namespace android.os 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Looper : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Looper() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.os.Looper), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.os.Looper(@__env); 
			} 
		} 
		protected Looper(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString5359; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Looper)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString5359)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Looper.staticClass, _toString5359)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _loop5360; 
		public static void loop() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Looper.staticClass, _loop5360); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _prepare5361; 
		public static void prepare() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Looper.staticClass, _prepare5361); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dump5362; 
		public virtual void dump(android.util.Printer arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Looper)) 
				@__env.CallVoidMethod(this, _dump5362, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Looper.staticClass, _dump5362, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMainLooper5363; 
		public static android.os.Looper getMainLooper() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Looper>(@__env, @__env.CallStaticObjectMethodPtr(android.os.Looper.staticClass, _getMainLooper5363)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _prepareMainLooper5364; 
		public static void prepareMainLooper() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Looper.staticClass, _prepareMainLooper5364); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _myLooper5365; 
		public static android.os.Looper myLooper() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Looper>(@__env, @__env.CallStaticObjectMethodPtr(android.os.Looper.staticClass, _myLooper5365)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMessageLogging5366; 
		public virtual void setMessageLogging(android.util.Printer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Looper)) 
				@__env.CallVoidMethod(this, _setMessageLogging5366, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Looper.staticClass, _setMessageLogging5366, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _myQueue5367; 
		public static android.os.MessageQueue myQueue() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.MessageQueue>(@__env, @__env.CallStaticObjectMethodPtr(android.os.Looper.staticClass, _myQueue5367)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _quit5368; 
		public virtual void quit() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Looper)) 
				@__env.CallVoidMethod(this, _quit5368); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Looper.staticClass, _quit5368); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getThread5369; 
		public virtual java.lang.Thread getThread() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Looper)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Thread>(@__env, @__env.CallObjectMethodPtr(this, _getThread5369)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Thread>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Looper.staticClass, _getThread5369)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.os.Looper.staticClass = @__class; 
			global::android.os.Looper._toString5359 = @__env.GetMethodID(global::android.os.Looper.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.os.Looper._loop5360 = @__env.GetStaticMethodID(global::android.os.Looper.staticClass, "loop", "()V"); 
			global::android.os.Looper._prepare5361 = @__env.GetStaticMethodID(global::android.os.Looper.staticClass, "prepare", "()V"); 
			global::android.os.Looper._dump5362 = @__env.GetMethodID(global::android.os.Looper.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V"); 
			global::android.os.Looper._getMainLooper5363 = @__env.GetStaticMethodID(global::android.os.Looper.staticClass, "getMainLooper", "()Landroid/os/Looper;"); 
			global::android.os.Looper._prepareMainLooper5364 = @__env.GetStaticMethodID(global::android.os.Looper.staticClass, "prepareMainLooper", "()V"); 
			global::android.os.Looper._myLooper5365 = @__env.GetStaticMethodID(global::android.os.Looper.staticClass, "myLooper", "()Landroid/os/Looper;"); 
			global::android.os.Looper._setMessageLogging5366 = @__env.GetMethodID(global::android.os.Looper.staticClass, "setMessageLogging", "(Landroid/util/Printer;)V"); 
			global::android.os.Looper._myQueue5367 = @__env.GetStaticMethodID(global::android.os.Looper.staticClass, "myQueue", "()Landroid/os/MessageQueue;"); 
			global::android.os.Looper._quit5368 = @__env.GetMethodID(global::android.os.Looper.staticClass, "quit", "()V"); 
			global::android.os.Looper._getThread5369 = @__env.GetMethodID(global::android.os.Looper.staticClass, "getThread", "()Ljava/lang/Thread;"); 
		} 
	} 
} 
