namespace android.widget
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.HeterogeneousExpandableList_))]
	public interface HeterogeneousExpandableList  : global::MonoJavaBridge.IJavaObject 
	{
		int getChildType(int arg0, int arg1);
		int getChildTypeCount();
		int getGroupType(int arg0);
		int getGroupTypeCount();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.HeterogeneousExpandableList))]
	public sealed partial class HeterogeneousExpandableList_ : java.lang.Object, HeterogeneousExpandableList
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HeterogeneousExpandableList_()
		{
			InitJNI();
		}
		internal HeterogeneousExpandableList_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getChildType11937;
		 int android.widget.HeterogeneousExpandableList.getChildType(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.HeterogeneousExpandableList_._getChildType11937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.HeterogeneousExpandableList_.staticClass, global::android.widget.HeterogeneousExpandableList_._getChildType11937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getChildTypeCount11938;
		 int android.widget.HeterogeneousExpandableList.getChildTypeCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.HeterogeneousExpandableList_._getChildTypeCount11938);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.HeterogeneousExpandableList_.staticClass, global::android.widget.HeterogeneousExpandableList_._getChildTypeCount11938);
		}
		internal static global::MonoJavaBridge.MethodId _getGroupType11939;
		 int android.widget.HeterogeneousExpandableList.getGroupType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.HeterogeneousExpandableList_._getGroupType11939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.HeterogeneousExpandableList_.staticClass, global::android.widget.HeterogeneousExpandableList_._getGroupType11939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getGroupTypeCount11940;
		 int android.widget.HeterogeneousExpandableList.getGroupTypeCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.HeterogeneousExpandableList_._getGroupTypeCount11940);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.HeterogeneousExpandableList_.staticClass, global::android.widget.HeterogeneousExpandableList_._getGroupTypeCount11940);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.HeterogeneousExpandableList_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/HeterogeneousExpandableList"));
			global::android.widget.HeterogeneousExpandableList_._getChildType11937 = @__env.GetMethodIDNoThrow(global::android.widget.HeterogeneousExpandableList_.staticClass, "getChildType", "(II)I");
			global::android.widget.HeterogeneousExpandableList_._getChildTypeCount11938 = @__env.GetMethodIDNoThrow(global::android.widget.HeterogeneousExpandableList_.staticClass, "getChildTypeCount", "()I");
			global::android.widget.HeterogeneousExpandableList_._getGroupType11939 = @__env.GetMethodIDNoThrow(global::android.widget.HeterogeneousExpandableList_.staticClass, "getGroupType", "(I)I");
			global::android.widget.HeterogeneousExpandableList_._getGroupTypeCount11940 = @__env.GetMethodIDNoThrow(global::android.widget.HeterogeneousExpandableList_.staticClass, "getGroupTypeCount", "()I");
		}
	}
}
