namespace android.text
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.text.ParcelableSpan_))]
	public partial interface ParcelableSpan : android.os.Parcelable
	{
		int getSpanTypeId();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.ParcelableSpan))]
	internal sealed partial class ParcelableSpan_ : java.lang.Object, ParcelableSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ParcelableSpan_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getSpanTypeId12903;
		int android.text.ParcelableSpan.getSpanTypeId()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.ParcelableSpan_._getSpanTypeId12903);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.ParcelableSpan_.staticClass, global::android.text.ParcelableSpan_._getSpanTypeId12903);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel12904;
		void android.os.Parcelable.writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.ParcelableSpan_._writeToParcel12904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.ParcelableSpan_.staticClass, global::android.text.ParcelableSpan_._writeToParcel12904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents12905;
		int android.os.Parcelable.describeContents()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.ParcelableSpan_._describeContents12905);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.ParcelableSpan_.staticClass, global::android.text.ParcelableSpan_._describeContents12905);
		}
		static ParcelableSpan_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.ParcelableSpan_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/ParcelableSpan"));
			global::android.text.ParcelableSpan_._getSpanTypeId12903 = @__env.GetMethodIDNoThrow(global::android.text.ParcelableSpan_.staticClass, "getSpanTypeId", "()I");
			global::android.text.ParcelableSpan_._writeToParcel12904 = @__env.GetMethodIDNoThrow(global::android.text.ParcelableSpan_.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.text.ParcelableSpan_._describeContents12905 = @__env.GetMethodIDNoThrow(global::android.text.ParcelableSpan_.staticClass, "describeContents", "()I");
		}
		internal static void InitJNI()
		{
		}
	}
}