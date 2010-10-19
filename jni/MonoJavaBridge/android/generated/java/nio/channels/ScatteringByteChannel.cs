namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.nio.channels.ScatteringByteChannel_))]
	public interface ScatteringByteChannel : ReadableByteChannel
	{
		long read(java.nio.ByteBuffer[] arg0, int arg1, int arg2);
		long read(java.nio.ByteBuffer[] arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.ScatteringByteChannel))]
	public sealed partial class ScatteringByteChannel_ : java.lang.Object, ScatteringByteChannel
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ScatteringByteChannel_()
		{
			InitJNI();
		}
		internal ScatteringByteChannel_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _read16837;
		 long java.nio.channels.ScatteringByteChannel.read(java.nio.ByteBuffer[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.ScatteringByteChannel_._read16837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.ScatteringByteChannel_.staticClass, global::java.nio.channels.ScatteringByteChannel_._read16837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read16838;
		 long java.nio.channels.ScatteringByteChannel.read(java.nio.ByteBuffer[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.ScatteringByteChannel_._read16838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.ScatteringByteChannel_.staticClass, global::java.nio.channels.ScatteringByteChannel_._read16838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _read16839;
		 int java.nio.channels.ReadableByteChannel.read(java.nio.ByteBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.ScatteringByteChannel_._read16839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.ScatteringByteChannel_.staticClass, global::java.nio.channels.ScatteringByteChannel_._read16839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _close16840;
		 void java.nio.channels.Channel.close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.ScatteringByteChannel_._close16840);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.ScatteringByteChannel_.staticClass, global::java.nio.channels.ScatteringByteChannel_._close16840);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen16841;
		 bool java.nio.channels.Channel.isOpen() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.ScatteringByteChannel_._isOpen16841);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.channels.ScatteringByteChannel_.staticClass, global::java.nio.channels.ScatteringByteChannel_._isOpen16841);
		}
		internal static global::MonoJavaBridge.MethodId _close16842;
		 void java.io.Closeable.close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.ScatteringByteChannel_._close16842);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.ScatteringByteChannel_.staticClass, global::java.nio.channels.ScatteringByteChannel_._close16842);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.ScatteringByteChannel_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/ScatteringByteChannel"));
			global::java.nio.channels.ScatteringByteChannel_._read16837 = @__env.GetMethodIDNoThrow(global::java.nio.channels.ScatteringByteChannel_.staticClass, "read", "([Ljava/nio/ByteBuffer;II)J");
			global::java.nio.channels.ScatteringByteChannel_._read16838 = @__env.GetMethodIDNoThrow(global::java.nio.channels.ScatteringByteChannel_.staticClass, "read", "([Ljava/nio/ByteBuffer;)J");
			global::java.nio.channels.ScatteringByteChannel_._read16839 = @__env.GetMethodIDNoThrow(global::java.nio.channels.ScatteringByteChannel_.staticClass, "read", "(Ljava/nio/ByteBuffer;)I");
			global::java.nio.channels.ScatteringByteChannel_._close16840 = @__env.GetMethodIDNoThrow(global::java.nio.channels.ScatteringByteChannel_.staticClass, "close", "()V");
			global::java.nio.channels.ScatteringByteChannel_._isOpen16841 = @__env.GetMethodIDNoThrow(global::java.nio.channels.ScatteringByteChannel_.staticClass, "isOpen", "()Z");
			global::java.nio.channels.ScatteringByteChannel_._close16842 = @__env.GetMethodIDNoThrow(global::java.nio.channels.ScatteringByteChannel_.staticClass, "close", "()V");
		}
	}
}
