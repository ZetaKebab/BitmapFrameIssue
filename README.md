## Info

* Launch the program
* See the error
* This does not happen with the other image (cover2.jpg)

## Error

System.IO.FileFormatException: 'Unexpected property type or value.'

Inner Exception:
COMException: The bitmap property type is unexpected. (0x88982F8E)

```
System.IO.FileFormatException
  HResult=0x80131537
  Message=Unexpected property type or value.
  Source=PresentationCore
  StackTrace:
   at System.Windows.Media.Imaging.BitmapDecoder.SetupDecoderFromUriOrStream(Uri uri, Stream stream, BitmapCacheOption cacheOption, Guid& clsId, Boolean& isOriginalWritable, Stream& uriStream, UnmanagedMemoryStream& unmanagedMemoryStream, SafeFileHandle& safeFilehandle)
   at System.Windows.Media.Imaging.BitmapDecoder.CreateFromUriOrStream(Uri baseUri, Uri uri, Stream stream, BitmapCreateOptions createOptions, BitmapCacheOption cacheOption, RequestCachePolicy uriCachePolicy, Boolean insertInDecoderCache)
   at System.Windows.Media.Imaging.BitmapDecoder.Create(Stream bitmapStream, BitmapCreateOptions createOptions, BitmapCacheOption cacheOption)
   at System.Windows.Media.Imaging.BitmapFrame.CreateFromUriOrStream(Uri baseUri, Uri uri, Stream stream, BitmapCreateOptions createOptions, BitmapCacheOption cacheOption, RequestCachePolicy uriCachePolicy)
   at System.Windows.Media.Imaging.BitmapFrame.Create(Stream bitmapStream, BitmapCreateOptions createOptions, BitmapCacheOption cacheOption)
   at WpfApp1.MainWindow..ctor() in C:\Users\keb\Desktop\BinaryIssue\WpfApp1\MainWindow.xaml.cs:line 15
   at System.RuntimeType.CreateInstanceDefaultCtor(Boolean publicOnly, Boolean wrapExceptions)
```

Inner Exception 1:
COMException: The bitmap property type is unexpected. (0x88982F8E)