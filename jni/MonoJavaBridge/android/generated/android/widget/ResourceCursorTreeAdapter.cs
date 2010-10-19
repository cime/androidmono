namespace android.widget
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.widget.ResourceCursorTreeAdapter_))]
	public abstract partial class ResourceCursorTreeAdapter : android.widget.ResourceCursorTreeAdapterScopeChangeShim
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ResourceCursorTreeAdapter()
		{
			InitJNI();
		}
		protected ResourceCursorTreeAdapter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _newGroupView12370;
		public virtual global::android.view.View newGroupView(android.content.Context arg0, android.database.Cursor arg1, bool arg2, android.view.ViewGroup arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ResourceCursorTreeAdapter._newGroupView12370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ResourceCursorTreeAdapter.staticClass, global::android.widget.ResourceCursorTreeAdapter._newGroupView12370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _newChildView12371;
		public virtual global::android.view.View newChildView(android.content.Context arg0, android.database.Cursor arg1, bool arg2, android.view.ViewGroup arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ResourceCursorTreeAdapter._newChildView12371, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ResourceCursorTreeAdapter.staticClass, global::android.widget.ResourceCursorTreeAdapter._newChildView12371, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _ResourceCursorTreeAdapter12372;
		public ResourceCursorTreeAdapter(android.content.Context arg0, android.database.Cursor arg1, int arg2, int arg3, int arg4, int arg5)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ResourceCursorTreeAdapter.staticClass, global::android.widget.ResourceCursorTreeAdapter._ResourceCursorTreeAdapter12372, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ResourceCursorTreeAdapter12373;
		public ResourceCursorTreeAdapter(android.content.Context arg0, android.database.Cursor arg1, int arg2, int arg3, int arg4)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ResourceCursorTreeAdapter.staticClass, global::android.widget.ResourceCursorTreeAdapter._ResourceCursorTreeAdapter12373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ResourceCursorTreeAdapter12374;
		public ResourceCursorTreeAdapter(android.content.Context arg0, android.database.Cursor arg1, int arg2, int arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ResourceCursorTreeAdapter.staticClass, global::android.widget.ResourceCursorTreeAdapter._ResourceCursorTreeAdapter12374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ResourceCursorTreeAdapter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ResourceCursorTreeAdapter"));
			global::android.widget.ResourceCursorTreeAdapter._newGroupView12370 = @__env.GetMethodIDNoThrow(global::android.widget.ResourceCursorTreeAdapter.staticClass, "newGroupView", "(Landroid/content/Context;Landroid/database/Cursor;ZLandroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.ResourceCursorTreeAdapter._newChildView12371 = @__env.GetMethodIDNoThrow(global::android.widget.ResourceCursorTreeAdapter.staticClass, "newChildView", "(Landroid/content/Context;Landroid/database/Cursor;ZLandroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.ResourceCursorTreeAdapter._ResourceCursorTreeAdapter12372 = @__env.GetMethodIDNoThrow(global::android.widget.ResourceCursorTreeAdapter.staticClass, "<init>", "(Landroid/content/Context;Landroid/database/Cursor;IIII)V");
			global::android.widget.ResourceCursorTreeAdapter._ResourceCursorTreeAdapter12373 = @__env.GetMethodIDNoThrow(global::android.widget.ResourceCursorTreeAdapter.staticClass, "<init>", "(Landroid/content/Context;Landroid/database/Cursor;III)V");
			global::android.widget.ResourceCursorTreeAdapter._ResourceCursorTreeAdapter12374 = @__env.GetMethodIDNoThrow(global::android.widget.ResourceCursorTreeAdapter.staticClass, "<init>", "(Landroid/content/Context;Landroid/database/Cursor;II)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.ResourceCursorTreeAdapter))]
	public sealed partial class ResourceCursorTreeAdapter_ : android.widget.ResourceCursorTreeAdapter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ResourceCursorTreeAdapter_()
		{
			InitJNI();
		}
		internal ResourceCursorTreeAdapter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getChildrenCursor12375;
		protected override global::android.database.Cursor getChildrenCursor(android.database.Cursor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ResourceCursorTreeAdapter_._getChildrenCursor12375, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.database.Cursor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ResourceCursorTreeAdapter_.staticClass, global::android.widget.ResourceCursorTreeAdapter_._getChildrenCursor12375, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.database.Cursor;
		}
		internal static global::MonoJavaBridge.MethodId _bindGroupView12376;
		protected override void bindGroupView(android.view.View arg0, android.content.Context arg1, android.database.Cursor arg2, bool arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ResourceCursorTreeAdapter_._bindGroupView12376, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ResourceCursorTreeAdapter_.staticClass, global::android.widget.ResourceCursorTreeAdapter_._bindGroupView12376, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _bindChildView12377;
		protected override void bindChildView(android.view.View arg0, android.content.Context arg1, android.database.Cursor arg2, bool arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ResourceCursorTreeAdapter_._bindChildView12377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ResourceCursorTreeAdapter_.staticClass, global::android.widget.ResourceCursorTreeAdapter_._bindChildView12377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ResourceCursorTreeAdapter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ResourceCursorTreeAdapter"));
			global::android.widget.ResourceCursorTreeAdapter_._getChildrenCursor12375 = @__env.GetMethodIDNoThrow(global::android.widget.ResourceCursorTreeAdapter_.staticClass, "getChildrenCursor", "(Landroid/database/Cursor;)Landroid/database/Cursor;");
			global::android.widget.ResourceCursorTreeAdapter_._bindGroupView12376 = @__env.GetMethodIDNoThrow(global::android.widget.ResourceCursorTreeAdapter_.staticClass, "bindGroupView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;Z)V");
			global::android.widget.ResourceCursorTreeAdapter_._bindChildView12377 = @__env.GetMethodIDNoThrow(global::android.widget.ResourceCursorTreeAdapter_.staticClass, "bindChildView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;Z)V");
		}
	}
}
