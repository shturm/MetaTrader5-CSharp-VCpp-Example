// MQLIntegrationVCpp.cpp : Defines the exported functions for the DLL application.
//

#include "stdafx.h"

extern "C" __declspec(dllexport)
int __stdcall GetTheAnswerOfEverything() {
	return 42;
}