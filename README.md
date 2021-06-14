# RegistryFilterExample
Registry monitoring and protection

The Registry Filter Driver is a kernel-mode driver that filters registry calls, it provides you an easy way to develop Windows application for registry monitoring and protection, track the registry change and prevent the registry from being changed by unauthorized processes or users. 

With the Registry Filter Driver, it allows your application to protect Windows core registry keys and values and to prevent potentially damaging system configuration changes, besides operating system files. 

By registering a RegistryCallback routine in the registry filter driver, it can receive notifications of each registry operation before the configuration manager processes the operation. A set of REG_XXX_KEY_INFORMATION data structures which contain information about each registry operation will return to your user mode application, your application can allow the registry access or change to authorized processes or users, and deny the registry access to unauthorized processes or users.
 
 
[Read more about registry filter example](https://www.easefilter.com/Forums_Files/RegMon.htm)
