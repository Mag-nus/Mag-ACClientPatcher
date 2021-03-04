# Mag-AC Client Patcher

## Usage Instructions
* Click "Locate" to locate your acclient.exe
* If your client exe is original, click "Create Backup" to backup.
* Click "Apply" on the various patches you'd like to use.
* Click "Commit Changes to Exe" to apply them.


## Included Patch Options

**Allow Multiclient**
 * This allows multiple instances of acclient.exe even when not using decal.

**Bypass RenderNormalMode**
 * This will not render the world.
 * This can greatly reduce CPU but doesn't reduce memory usage much.
  
**Pea 4K Res Unlocked**
 * This patch was developed by Pea.
 * Pea has given me persmission to deploy this patch.
 * This allows the client to select larger resolutions.
 * It does not fix text scaling issues at such high resolutions.

**Client::UseTime Disable StartFrame and Draw**
 * This will not render anything past initial connection. You will only see a black screen.
 * It removes almost all CPU/GPU based load but doesn't reduce memory usage much.
 * Mouse inputs will still register
 * Decal plugins will still run, but do not render.

<br/>
<br/>

![Launcher](/Docs/Images/Main.png?raw=true)

<br/>
<br/>

**Tools I use to develop these patches**
 * AC Client 2013-09 11.4186 for reference
 * IDA v6.6 - v6.9 to analyze the exe
 * OllyDbg 2.01 to modify the assembly and save a patched exe
