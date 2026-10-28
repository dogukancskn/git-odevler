using System;

namespace Odev3_DenetimGunlugu.Services;

public class AuditLogWriter : IDisposable
{
    private readonly StreamWriter _writer;
    private bool disposed;

    public AuditLogWriter(string path)
    {
        _writer = new StreamWriter(
            path,
            append: false
        );
    }
    public void Write(string eventName, string details)
    {

        ObjectDisposedException.ThrowIf(disposed,this);

        string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        _writer.WriteLine($"[{date}] {eventName} {details}");
        _writer.Flush();
    }
    public void Dispose()
    {
        if (disposed) return;
        disposed = true;
        _writer.Dispose();
    }
}
