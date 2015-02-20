# PAD (Portable Application Description) Generator
[![NuGet Version](http://img.shields.io/nuget/v/TAlex.PADGenerator.svg?style=flat)](https://www.nuget.org/packages/TAlex.PADGenerator/) [![NuGet Downloads](http://img.shields.io/nuget/dt/TAlex.PADGenerator.svg?style=flat)](https://www.nuget.org/packages/TAlex.PADGenerator/)

PAD file generator library.

## Example of usage
Here is example of typical using of library:

```C#
PADRoot root = new PADRoot();
root.ProgramDescriptions.Add("English", new ProgramDescription());

root.CompanyInfo.Name = "T-Alex Software";
root.CompanyInfo.City = "San Francisco";
root.CompanyInfo.Country = "USA";
root.CompanyInfo.WebSiteUrl = "http://www.talex-soft.com";
root.CompanyInfo.ContactInfo.AuthorFirstName = "Firstname";
root.CompanyInfo.ContactInfo.AuthorLastName = "Lastname";
root.CompanyInfo.ContactInfo.ContactFirstName = "Firstname";
root.CompanyInfo.ContactInfo.ContactLastName = "Lastname";
root.ProgramInfo.ProgramName = "Cool Program";
root.ProgramInfo.Version = "2.0";
root.ProgramInfo.SetReleaseDate(new DateTime(2013, 1, 3));
root.ProgramInfo.Category = "Desktop::Screen Savers: Science";
root.ProgramInfo.FileInfo.SetFileSize(3645785);

Stream outputStream = new MemoryStream();
PADGenerator.Generate(root, outputStream);
```
Output:
```XML
<?xml version="1.0" encoding="utf-8"?>
<XML_DIZ_INFO>
  <MASTER_PAD_VERSION_INFO>
    <MASTER_PAD_VERSION>4.0</MASTER_PAD_VERSION>
    <MASTER_PAD_EDITOR>TAlex PAD Generator 1.0.2.0</MASTER_PAD_EDITOR>
    <MASTER_PAD_INFO>Portable Application Description, or PAD for short, is a data set that is used by shareware authors to disseminate information to anyone interested in their software products. To find out more go to http://pad.asp-software.org</MASTER_PAD_INFO>
  </MASTER_PAD_VERSION_INFO>
  <Company_Info>
    <Company_Name>T-Alex Software</Company_Name>
    <Address_1 />
    <Address_2 />
    <City_Town>San Francisco</City_Town>
    <State_Province />
    <Zip_Postal_Code />
    <Country>USA</Country>
    <Company_WebSite_URL>http://www.talex-soft.com</Company_WebSite_URL>
    <Contact_Info>
      <Author_First_Name>Firstname</Author_First_Name>
      <Author_Last_Name>Lastname</Author_Last_Name>
      <Author_Email />
      <Contact_First_Name>Firstname</Contact_First_Name>
      <Contact_Last_Name>Lastname</Contact_Last_Name>
      <Contact_Email />
    </Contact_Info>
    <Support_Info>
      <Sales_Email />
      <Support_Email />
      <General_Email />
      <Sales_Phone />
      <Support_Phone />
      <General_Phone />
      <Fax_Phone />
    </Support_Info>
  </Company_Info>
  <Program_Info>
    <Program_Name>Cool Program</Program_Name>
    <Program_Version>2.0</Program_Version>
    <Program_Release_Month>01</Program_Release_Month>
    <Program_Release_Day>03</Program_Release_Day>
    <Program_Release_Year>2013</Program_Release_Year>
    <Program_Cost_Dollars />
    <Program_Cost_Other_Code />
    <Program_Cost_Other />
    <Program_Type />
    <Program_Release_Status />
    <Program_Install_Support />
    <Program_OS_Support />
    <Program_Language />
    <File_Info>
      <File_Size_Bytes>3645785</File_Size_Bytes>
      <File_Size_K>3560</File_Size_K>
      <File_Size_MB>3.48</File_Size_MB>
    </File_Info>
    <Expire_Info>
      <Has_Expire_Info />
      <Expire_Count />
      <Expire_Based_On />
      <Expire_Other_Info />
      <Expire_Month />
      <Expire_Day />
      <Expire_Year />
    </Expire_Info>
    <Program_Change_Info />
    <Program_Category_Class>Desktop::Screen Savers: Science</Program_Category_Class>
    <Program_Specific_Category />
    <Program_System_Requirements />
  </Program_Info>
  <Program_Descriptions>
    <English>
      <Keywords />
      <Char_Desc_45 />
      <Char_Desc_80 />
      <Char_Desc_250 />
      <Char_Desc_450 />
      <Char_Desc_2000 />
    </English>
  </Program_Descriptions>
  <Web_Info>
    <Application_URLs>
      <Application_Info_URL />
      <Application_Order_URL />
      <Application_Screenshot_URL />
      <Application_Icon_URL />
      <Application_XML_File_URL />
    </Application_URLs>
    <Download_URLs>
      <Primary_Download_URL />
      <Secondary_Download_URL />
      <Additional_Download_URL_1 />
      <Additional_Download_URL_2 />
    </Download_URLs>
  </Web_Info>
  <Permissions>
    <Distribution_Permissions />
    <EULA />
  </Permissions>
</XML_DIZ_INFO>
```


## Get it on NuGet!

    Install-Package TAlex.PADGenerator

## License
TAlex.PADGenerator is under the [MIT license](https://github.com/T-Alex/PADGenerator/blob/master/LICENSE.md).
