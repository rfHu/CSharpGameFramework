﻿using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_GameFramework_AttrCalc_IAttrExpression : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Calc(IntPtr l) {
		try {
			GameFramework.AttrCalc.IAttrExpression self=(GameFramework.AttrCalc.IAttrExpression)checkSelf(l);
			GameFramework.SceneContextInfo a1;
			checkType(l,2,out a1);
			GameFramework.CharacterProperty a2;
			checkType(l,3,out a2);
			GameFramework.CharacterProperty a3;
			checkType(l,4,out a3);
			System.Int64[] a4;
			checkArray(l,5,out a4);
			var ret=self.Calc(a1,a2,a3,a4);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Load(IntPtr l) {
		try {
			GameFramework.AttrCalc.IAttrExpression self=(GameFramework.AttrCalc.IAttrExpression)checkSelf(l);
			Dsl.ISyntaxComponent a1;
			checkType(l,2,out a1);
			GameFramework.AttrCalc.DslCalculator a2;
			checkType(l,3,out a2);
			var ret=self.Load(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"GameFramework.AttrCalc.IAttrExpression");
		addMember(l,Calc);
		addMember(l,Load);
		createTypeMetatable(l,null, typeof(GameFramework.AttrCalc.IAttrExpression));
	}
}
