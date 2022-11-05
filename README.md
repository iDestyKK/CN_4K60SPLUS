# CN\_4K60S+

*Because I want to treat the SD card like a footage cartridge*

## About
CN\_4K60S+ is a GUI that I wrote based on some Bash Scripts to provide a GUI to
me and my friends using the
[Elgato 4K60 S+](https://www.elgato.com/en/game-capture-4k60-s-plus) for
recording gameplay. I wanted to provide something that can deal with the card
in FAT32 mode, since I see that as the ideal mode. It has lossless audio. And
a one-click solution for dealing with split up files to be concatenated via
FFmpeg was too good to pass up.

## Features
* Automatically organises and predicts what footage on SD card should be concatenated
* Export your videos with choice of format:
  * MKV for archival
  * MP4 for portability
  * AVI for whatever else you need, probably
* Provides video encoding options supplied by FFmpeg:
  * **Stream copy**, so video is stitched together **with no quality loss** and is copied to your drive at the fastest possible speed.
  * **libx265 (HEVC)**, if you want to quickly recompress your video to HEVC with CRF and preset options.
  * **libx264 (H.264)**, if you want H.264 instead with CRF and preset options.
* Provides audio encoding options supplied by FFmpeg:
  * **Stream copy**, so the pcm\_s16le WAV audio track is copied without any quality loss
  * **FLAC**, so the audio is compressed losslessly into FLAC to save some space
  * **Separate WAV file**. If you plan to edit the merged video in the future, you might want an MP4 file along with a WAV for audio. This does that.
* Basic metadata support. `DATE_ENCODED` and `TITLE` are set when concatenating.
* View basic file info
  * Resolution, codec, framerate, colourspace, filesize
  * Predicts concatenated filesize so you know what you're dealing with before you run the encoding job

Planned features include:
* One click solution to automatically concatenate and compress all files on the SD card while copying to disk.
* Being able to upload to YouTube automatically via supplying a `client_secrets` file.
* Queueing up render jobs so you don't have to interact with the program on a per-video basis

## Preview
![Preview](../assets/assets/screenshot.png?raw=true)
