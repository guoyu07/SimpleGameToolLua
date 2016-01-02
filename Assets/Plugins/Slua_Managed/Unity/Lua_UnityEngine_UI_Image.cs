﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_Image : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnBeforeSerialize(IntPtr l) {
		try {
			UnityEngine.UI.Image self=(UnityEngine.UI.Image)checkSelf(l);
			self.OnBeforeSerialize();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetNativeSize(IntPtr l) {
		try {
			UnityEngine.UI.Image self=(UnityEngine.UI.Image)checkSelf(l);
			self.SetNativeSize();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CalculateLayoutInputHorizontal(IntPtr l) {
		try {
			UnityEngine.UI.Image self=(UnityEngine.UI.Image)checkSelf(l);
			self.CalculateLayoutInputHorizontal();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CalculateLayoutInputVertical(IntPtr l) {
		try {
			UnityEngine.UI.Image self=(UnityEngine.UI.Image)checkSelf(l);
			self.CalculateLayoutInputVertical();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sprite(IntPtr l) {
		try {
			UnityEngine.UI.Image self=(UnityEngine.UI.Image)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.sprite);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sprite(IntPtr l) {
		try {
			UnityEngine.UI.Image self=(UnityEngine.UI.Image)checkSelf(l);
			UnityEngine.Sprite v;
			checkType(l,2,out v);
			self.sprite=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_overrideSprite(IntPtr l) {
		try {
			UnityEngine.UI.Image self=(UnityEngine.UI.Image)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.overrideSprite);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_overrideSprite(IntPtr l) {
		try {
			UnityEngine.UI.Image self=(UnityEngine.UI.Image)checkSelf(l);
			UnityEngine.Sprite v;
			checkType(l,2,out v);
			self.overrideSprite=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_type(IntPtr l) {
		try {
			UnityEngine.UI.Image self=(UnityEngine.UI.Image)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.type);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_type(IntPtr l) {
		try {
			UnityEngine.UI.Image self=(UnityEngine.UI.Image)checkSelf(l);
			UnityEngine.UI.Image.Type v;
			checkEnum(l,2,out v);
			self.type=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_preserveAspect(IntPtr l) {
		try {
			UnityEngine.UI.Image self=(UnityEngine.UI.Image)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.preserveAspect);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_preserveAspect(IntPtr l) {
		try {
			UnityEngine.UI.Image self=(UnityEngine.UI.Image)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.preserveAspect=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fillCenter(IntPtr l) {
		try {
			UnityEngine.UI.Image self=(UnityEngine.UI.Image)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.fillCenter);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fillCenter(IntPtr l) {
		try {
			UnityEngine.UI.Image self=(UnityEngine.UI.Image)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.fillCenter=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fillMethod(IntPtr l) {
		try {
			UnityEngine.UI.Image self=(UnityEngine.UI.Image)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.fillMethod);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fillMethod(IntPtr l) {
		try {
			UnityEngine.UI.Image self=(UnityEngine.UI.Image)checkSelf(l);
			UnityEngine.UI.Image.FillMethod v;
			checkEnum(l,2,out v);
			self.fillMethod=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fillAmount(IntPtr l) {
		try {
			UnityEngine.UI.Image self=(UnityEngine.UI.Image)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.fillAmount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fillAmount(IntPtr l) {
		try {
			UnityEngine.UI.Image self=(UnityEngine.UI.Image)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.fillAmount=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fillClockwise(IntPtr l) {
		try {
			UnityEngine.UI.Image self=(UnityEngine.UI.Image)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.fillClockwise);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fillClockwise(IntPtr l) {
		try {
			UnityEngine.UI.Image self=(UnityEngine.UI.Image)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.fillClockwise=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fillOrigin(IntPtr l) {
		try {
			UnityEngine.UI.Image self=(UnityEngine.UI.Image)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.fillOrigin);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fillOrigin(IntPtr l) {
		try {
			UnityEngine.UI.Image self=(UnityEngine.UI.Image)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.fillOrigin=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mainTexture(IntPtr l) {
		try {
			UnityEngine.UI.Image self=(UnityEngine.UI.Image)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.mainTexture);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hasBorder(IntPtr l) {
		try {
			UnityEngine.UI.Image self=(UnityEngine.UI.Image)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.hasBorder);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minWidth(IntPtr l) {
		try {
			UnityEngine.UI.Image self=(UnityEngine.UI.Image)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.minWidth);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_preferredWidth(IntPtr l) {
		try {
			UnityEngine.UI.Image self=(UnityEngine.UI.Image)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.preferredWidth);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_flexibleWidth(IntPtr l) {
		try {
			UnityEngine.UI.Image self=(UnityEngine.UI.Image)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.flexibleWidth);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minHeight(IntPtr l) {
		try {
			UnityEngine.UI.Image self=(UnityEngine.UI.Image)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.minHeight);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_preferredHeight(IntPtr l) {
		try {
			UnityEngine.UI.Image self=(UnityEngine.UI.Image)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.preferredHeight);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_flexibleHeight(IntPtr l) {
		try {
			UnityEngine.UI.Image self=(UnityEngine.UI.Image)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.flexibleHeight);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_layoutPriority(IntPtr l) {
		try {
			UnityEngine.UI.Image self=(UnityEngine.UI.Image)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.layoutPriority);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.Image");
		addMember(l,OnBeforeSerialize);
		addMember(l,SetNativeSize);
		addMember(l,CalculateLayoutInputHorizontal);
		addMember(l,CalculateLayoutInputVertical);
		addMember(l,"sprite",get_sprite,set_sprite,true);
		addMember(l,"overrideSprite",get_overrideSprite,set_overrideSprite,true);
		addMember(l,"type",get_type,set_type,true);
		addMember(l,"preserveAspect",get_preserveAspect,set_preserveAspect,true);
		addMember(l,"fillCenter",get_fillCenter,set_fillCenter,true);
		addMember(l,"fillMethod",get_fillMethod,set_fillMethod,true);
		addMember(l,"fillAmount",get_fillAmount,set_fillAmount,true);
		addMember(l,"fillClockwise",get_fillClockwise,set_fillClockwise,true);
		addMember(l,"fillOrigin",get_fillOrigin,set_fillOrigin,true);
		addMember(l,"mainTexture",get_mainTexture,null,true);
		addMember(l,"hasBorder",get_hasBorder,null,true);
		addMember(l,"minWidth",get_minWidth,null,true);
		addMember(l,"preferredWidth",get_preferredWidth,null,true);
		addMember(l,"flexibleWidth",get_flexibleWidth,null,true);
		addMember(l,"minHeight",get_minHeight,null,true);
		addMember(l,"preferredHeight",get_preferredHeight,null,true);
		addMember(l,"flexibleHeight",get_flexibleHeight,null,true);
		addMember(l,"layoutPriority",get_layoutPriority,null,true);
		createTypeMetatable(l,null, typeof(UnityEngine.UI.Image),typeof(UnityEngine.UI.MaskableGraphic));
	}
}
