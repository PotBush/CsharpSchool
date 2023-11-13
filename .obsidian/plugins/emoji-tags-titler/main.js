/*
THIS IS A GENERATED/BUNDLED FILE BY ESBUILD
if you want to view the source, please visit the github repository of this plugin
*/

var __defProp = Object.defineProperty;
var __getOwnPropDesc = Object.getOwnPropertyDescriptor;
var __getOwnPropNames = Object.getOwnPropertyNames;
var __hasOwnProp = Object.prototype.hasOwnProperty;
var __export = (target, all) => {
  for (var name in all)
    __defProp(target, name, { get: all[name], enumerable: true });
};
var __copyProps = (to, from, except, desc) => {
  if (from && typeof from === "object" || typeof from === "function") {
    for (let key of __getOwnPropNames(from))
      if (!__hasOwnProp.call(to, key) && key !== except)
        __defProp(to, key, { get: () => from[key], enumerable: !(desc = __getOwnPropDesc(from, key)) || desc.enumerable });
  }
  return to;
};
var __toCommonJS = (mod) => __copyProps(__defProp({}, "__esModule", { value: true }), mod);

// main.ts
var main_exports = {};
__export(main_exports, {
  default: () => EmoTagsTitler
});
module.exports = __toCommonJS(main_exports);
var import_obsidian = require("obsidian");
var EmoTagsTitler = class extends import_obsidian.Plugin {
  constructor() {
    super(...arguments);
    this.emojiDetectRegex = /(\p{Emoji_Presentation}|\p{Emoji}\uFE0F)/gu;
    this.emojiReplaceRegex = /^(\p{Emoji_Presentation}|\p{Emoji}\uFE0F)+\s*/gu;
  }
  // Define a method to run when your plugin is loaded
  async onload() {
    this.registerEvent(
      this.app.metadataCache.on("changed", this.addTagsEmojiToTitle.bind(this))
    );
    this.addCommand({
      id: "add-emojis-to-all-notes",
      name: "Add emojis to the titles of all notes that have emoji tags",
      callback: () => {
        this.addEmojisToAllNotes();
      }
    });
    this.addCommand({
      id: "remove-emojis-from-all-notes",
      name: "Remove emojis from the titles of all notes",
      callback: () => {
        this.removeEmojisFromAllNotes();
      }
    });
  }
  addTagsEmojiToTitle(file) {
    var _a, _b;
    const tags = this.app.metadataCache.getFileCache(file).tags;
    if (file.parent == null)
      return;
    const dir = file.parent.path;
    const noteTitle = file.basename;
    if (tags) {
      let emojis = [];
      for (const tag of tags) {
        const tagName = tag.tag;
        if (this.emojiDetectRegex.test(tagName)) {
          let tagEmojis = Array.from((_a = tagName.match(this.emojiDetectRegex)) != null ? _a : []);
          tagEmojis = tagEmojis.filter((element) => !emojis.includes(element));
          emojis = [...emojis, ...tagEmojis];
        }
      }
      const noteTitleWithoutEmoji = noteTitle.replace(this.emojiReplaceRegex, "");
      if (emojis.length > 0) {
        const emojiHeader = (_b = emojis == null ? void 0 : emojis.join("")) != null ? _b : "";
        const newNoteTitle = emojiHeader + " " + noteTitleWithoutEmoji;
        const filePath = dir + "/" + newNoteTitle + ".md";
        this.app.fileManager.renameFile(file, filePath);
      }
    } else {
      let newNoteTitle = noteTitle.replace(this.emojiDetectRegex, "");
      newNoteTitle = newNoteTitle.trim();
      const filePath = dir + "/" + newNoteTitle + ".md";
      this.app.fileManager.renameFile(file, filePath);
    }
  }
  addEmojisToAllNotes() {
    const files = this.app.vault.getMarkdownFiles();
    for (const file of files) {
      this.addTagsEmojiToTitle(file);
    }
  }
  removeTagsEmojiFromTitle(note) {
    var _a;
    const tags = this.app.metadataCache.getFileCache(note).tags;
    if (note.parent == null)
      return;
    const dir = note.parent.path;
    let noteTitle = note.basename;
    if (tags) {
      for (const tag of tags) {
        const tagName = tag.tag;
        if (this.emojiDetectRegex.test(tagName)) {
          const tagEmojis = Array.from((_a = tagName.match(this.emojiDetectRegex)) != null ? _a : []);
          for (const emoji of tagEmojis) {
            noteTitle = noteTitle.replace(emoji, "");
          }
        }
      }
      noteTitle = noteTitle.trim();
      const filePath = dir + "/" + noteTitle + ".md";
      this.app.fileManager.renameFile(note, filePath);
    }
  }
  removeEmojisFromAllNotes() {
    const files = this.app.vault.getMarkdownFiles();
    for (const file of files) {
      this.removeTagsEmojiFromTitle(file);
    }
  }
};
//# sourceMappingURL=data:application/json;base64,ewogICJ2ZXJzaW9uIjogMywKICAic291cmNlcyI6IFsibWFpbi50cyJdLAogICJzb3VyY2VzQ29udGVudCI6IFsiaW1wb3J0IHtQbHVnaW4sIFRGaWxlfSBmcm9tICdvYnNpZGlhbic7XG5cblxuZXhwb3J0IGRlZmF1bHQgY2xhc3MgRW1vVGFnc1RpdGxlciBleHRlbmRzIFBsdWdpbiB7XG5cblx0ZW1vamlEZXRlY3RSZWdleCA9IC8oXFxwe0Vtb2ppX1ByZXNlbnRhdGlvbn18XFxwe0Vtb2ppfVxcdUZFMEYpL2d1XG5cblx0ZW1vamlSZXBsYWNlUmVnZXggPSAvXihcXHB7RW1vamlfUHJlc2VudGF0aW9ufXxcXHB7RW1vaml9XFx1RkUwRikrXFxzKi9ndVxuXG5cdC8vIERlZmluZSBhIG1ldGhvZCB0byBydW4gd2hlbiB5b3VyIHBsdWdpbiBpcyBsb2FkZWRcblx0YXN5bmMgb25sb2FkKCkge1xuXHRcdC8vIFJlZ2lzdGVyIGEgaG9vayB0byBsaXN0ZW4gZm9yIGNoYW5nZXMgaW4gdGhlIG1ldGFkYXRhIG9mIG5vdGVzXG5cdFx0dGhpcy5yZWdpc3RlckV2ZW50KFxuXHRcdFx0dGhpcy5hcHAubWV0YWRhdGFDYWNoZS5vbignY2hhbmdlZCcsIHRoaXMuYWRkVGFnc0Vtb2ppVG9UaXRsZS5iaW5kKHRoaXMpKVxuXHRcdCk7XG5cblx0XHQvLyBBZGQgYSBjb21tYW5kIHRvIHRoZSBwbHVnaW5cblx0XHR0aGlzLmFkZENvbW1hbmQoe1xuXHRcdFx0aWQ6ICdhZGQtZW1vamlzLXRvLWFsbC1ub3RlcycsXG5cdFx0XHRuYW1lOiAnQWRkIGVtb2ppcyB0byB0aGUgdGl0bGVzIG9mIGFsbCBub3RlcyB0aGF0IGhhdmUgZW1vamkgdGFncycsXG5cdFx0XHRjYWxsYmFjazogKCkgPT4ge1xuXHRcdFx0XHR0aGlzLmFkZEVtb2ppc1RvQWxsTm90ZXMoKTtcblx0XHRcdH0sXG5cdFx0fSk7XG5cblx0XHR0aGlzLmFkZENvbW1hbmQoe1xuXHRcdFx0aWQ6ICdyZW1vdmUtZW1vamlzLWZyb20tYWxsLW5vdGVzJyxcblx0XHRcdG5hbWU6ICdSZW1vdmUgZW1vamlzIGZyb20gdGhlIHRpdGxlcyBvZiBhbGwgbm90ZXMnLFxuXHRcdFx0Y2FsbGJhY2s6ICgpID0+IHtcblx0XHRcdFx0dGhpcy5yZW1vdmVFbW9qaXNGcm9tQWxsTm90ZXMoKTtcblx0XHRcdH0sXG5cdFx0fSk7XG5cdH1cblxuXHRwcml2YXRlIGFkZFRhZ3NFbW9qaVRvVGl0bGUoZmlsZTogVEZpbGUpIHtcblx0XHQvLyBHZXQgdGhlIHRhZ3Mgb2YgdGhlIGN1cnJlbnQgbm90ZVxuXG5cdFx0Y29uc3QgdGFncyA9IHRoaXMuYXBwLm1ldGFkYXRhQ2FjaGUuZ2V0RmlsZUNhY2hlKGZpbGUpLnRhZ3M7XG5cdFx0aWYgKGZpbGUucGFyZW50ID09IG51bGwpIHJldHVybjtcblx0XHRjb25zdCBkaXIgPSBmaWxlLnBhcmVudC5wYXRoXG5cdFx0Ly8gR2V0IHRoZSBjdXJyZW50IG5vdGUgdGl0bGVcblx0XHRjb25zdCBub3RlVGl0bGUgPSBmaWxlLmJhc2VuYW1lO1xuXHRcdC8vIENoZWNrIGlmIHRoZXJlIGFyZSBhbnkgdGFnc1xuXHRcdGlmICh0YWdzKSB7XG5cblx0XHRcdC8vIExvb3AgdGhyb3VnaCB0aGUgdGFnc1xuXHRcdFx0bGV0IGVtb2ppczogc3RyaW5nW10gPSBbXVxuXHRcdFx0Zm9yIChjb25zdCB0YWcgb2YgdGFncykge1xuXHRcdFx0XHQvLyBHZXQgdGhlIHRhZyBuYW1lXG5cdFx0XHRcdGNvbnN0IHRhZ05hbWUgPSB0YWcudGFnO1xuXHRcdFx0XHQvLyBDaGVjayBpZiB0aGUgdGFnIG5hbWUgY29udGFpbnMgYW4gZW1vamlcblx0XHRcdFx0aWYgKHRoaXMuZW1vamlEZXRlY3RSZWdleC50ZXN0KHRhZ05hbWUpKSB7XG5cdFx0XHRcdFx0Ly8gR2V0IHRoZSBlbW9qaSBmcm9tIHRoZSB0YWcgbmFtZVxuXHRcdFx0XHRcdGxldCB0YWdFbW9qaXM6IHN0cmluZ1tdID0gQXJyYXkuZnJvbSh0YWdOYW1lLm1hdGNoKHRoaXMuZW1vamlEZXRlY3RSZWdleCkgPz8gW10pO1xuXHRcdFx0XHRcdHRhZ0Vtb2ppcyA9IHRhZ0Vtb2ppcy5maWx0ZXIoZWxlbWVudCA9PiAhZW1vamlzLmluY2x1ZGVzKGVsZW1lbnQpKVxuXG5cdFx0XHRcdFx0ZW1vamlzID0gWy4uLmVtb2ppcywgLi4udGFnRW1vamlzXVxuXG5cdFx0XHRcdH1cblx0XHRcdH1cblxuXHRcdFx0Y29uc3Qgbm90ZVRpdGxlV2l0aG91dEVtb2ppID0gbm90ZVRpdGxlLnJlcGxhY2UodGhpcy5lbW9qaVJlcGxhY2VSZWdleCwgXCJcIilcblx0XHRcdGlmIChlbW9qaXMubGVuZ3RoID4gMCkge1xuXHRcdFx0XHRjb25zdCBlbW9qaUhlYWRlciA9IGVtb2ppcz8uam9pbignJykgPz8gJydcblx0XHRcdFx0Y29uc3QgbmV3Tm90ZVRpdGxlID0gZW1vamlIZWFkZXIgKyAnICcgKyBub3RlVGl0bGVXaXRob3V0RW1vamk7XG5cdFx0XHRcdGNvbnN0IGZpbGVQYXRoID0gZGlyICsgJy8nICsgbmV3Tm90ZVRpdGxlICsgJy5tZCdcblx0XHRcdFx0dGhpcy5hcHAuZmlsZU1hbmFnZXIucmVuYW1lRmlsZShmaWxlLCBmaWxlUGF0aCk7XG5cdFx0XHR9XG5cblx0XHR9IGVsc2Uge1xuXHRcdFx0Ly8gSWYgdGhlcmUgYXJlIG5vIHRhZ3MsIHJlbW92ZSBhbGwgZW1vamlzIGZyb20gdGhlIG5vdGUgdGl0bGVcblx0XHRcdC8vIFJlcGxhY2UgYWxsIGVtb2ppcyB3aXRoIGFuIGVtcHR5IHN0cmluZ1xuXHRcdFx0bGV0IG5ld05vdGVUaXRsZSA9IG5vdGVUaXRsZS5yZXBsYWNlKHRoaXMuZW1vamlEZXRlY3RSZWdleCwgJycpO1xuXHRcdFx0Ly8gVHJpbSBhbnkgZXh0cmEgc3BhY2VzXG5cdFx0XHRuZXdOb3RlVGl0bGUgPSBuZXdOb3RlVGl0bGUudHJpbSgpO1xuXHRcdFx0Ly8gUmVuYW1lIHRoZSBub3RlIGZpbGUgd2l0aCB0aGUgbmV3IHRpdGxlXG5cdFx0XHRjb25zdCBmaWxlUGF0aCA9IGRpciArICcvJyArIG5ld05vdGVUaXRsZSArICcubWQnXG5cdFx0XHR0aGlzLmFwcC5maWxlTWFuYWdlci5yZW5hbWVGaWxlKGZpbGUsIGZpbGVQYXRoKTtcblx0XHR9XG5cdH1cblxuXHRwcml2YXRlIGFkZEVtb2ppc1RvQWxsTm90ZXMoKSB7XG5cdFx0Ly8gR2V0IGFsbCB0aGUgbWFya2Rvd24gZmlsZXMgaW4gdGhlIHZhdWx0XG5cdFx0Y29uc3QgZmlsZXMgPSB0aGlzLmFwcC52YXVsdC5nZXRNYXJrZG93bkZpbGVzKCk7XG5cdFx0Ly8gTG9vcCB0aHJvdWdoIHRoZSBmaWxlc1xuXHRcdGZvciAoY29uc3QgZmlsZSBvZiBmaWxlcykge1xuXHRcdFx0Ly8gQ2FsbCB0aGUgYWRkVGFnc0Vtb2ppVG9UaXRsZSBmdW5jdGlvbiBvbiBlYWNoIGZpbGVcblx0XHRcdHRoaXMuYWRkVGFnc0Vtb2ppVG9UaXRsZShmaWxlKTtcblx0XHR9XG5cdH1cblxuXHRwcml2YXRlIHJlbW92ZVRhZ3NFbW9qaUZyb21UaXRsZShub3RlOiBURmlsZSkge1xuXG5cdFx0Ly8gQ2hlY2sgaWYgdGhlIGNoYW5nZWQgZmlsZSBpcyB0aGUgY3VycmVudCBub3RlXG5cblx0XHQvLyBHZXQgdGhlIHRhZ3Mgb2YgdGhlIGN1cnJlbnQgbm90ZVxuXHRcdGNvbnN0IHRhZ3MgPSB0aGlzLmFwcC5tZXRhZGF0YUNhY2hlLmdldEZpbGVDYWNoZShub3RlKS50YWdzO1xuXHRcdGlmIChub3RlLnBhcmVudCA9PSBudWxsKSByZXR1cm47XG5cdFx0Y29uc3QgZGlyID0gbm90ZS5wYXJlbnQucGF0aFxuXHRcdGxldCBub3RlVGl0bGUgPSBub3RlLmJhc2VuYW1lO1xuXHRcdC8vIENoZWNrIGlmIHRoZXJlIGFyZSBhbnkgdGFnc1xuXHRcdGlmICh0YWdzKSB7XG5cdFx0XHQvLyBMb29wIHRocm91Z2ggdGhlIHRhZ3Ncblx0XHRcdGZvciAoY29uc3QgdGFnIG9mIHRhZ3MpIHtcblx0XHRcdFx0Ly8gR2V0IHRoZSB0YWcgbmFtZVxuXHRcdFx0XHRjb25zdCB0YWdOYW1lID0gdGFnLnRhZztcblx0XHRcdFx0Ly8gQ2hlY2sgaWYgdGhlIHRhZyBuYW1lIGNvbnRhaW5zIGFuIGVtb2ppXG5cdFx0XHRcdGlmICh0aGlzLmVtb2ppRGV0ZWN0UmVnZXgudGVzdCh0YWdOYW1lKSkge1xuXHRcdFx0XHRcdC8vIEdldCB0aGUgZW1vamkgZnJvbSB0aGUgdGFnIG5hbWVcblx0XHRcdFx0XHRjb25zdCB0YWdFbW9qaXM6IHN0cmluZ1tdID0gQXJyYXkuZnJvbSh0YWdOYW1lLm1hdGNoKHRoaXMuZW1vamlEZXRlY3RSZWdleCkgPz8gW10pO1xuXHRcdFx0XHRcdC8vIExvb3AgdGhyb3VnaCB0aGUgdGFnIGVtb2ppc1xuXHRcdFx0XHRcdGZvciAoY29uc3QgZW1vamkgb2YgdGFnRW1vamlzKSB7XG5cdFx0XHRcdFx0XHQvLyBSZXBsYWNlIHRoZSBlbW9qaSBpbiB0aGUgbm90ZSB0aXRsZSB3aXRoIGFuIGVtcHR5IHN0cmluZ1xuXHRcdFx0XHRcdFx0bm90ZVRpdGxlID0gbm90ZVRpdGxlLnJlcGxhY2UoZW1vamksICcnKTtcblx0XHRcdFx0XHR9XG5cdFx0XHRcdH1cblx0XHRcdH1cblx0XHRcdC8vIFRyaW0gYW55IGV4dHJhIHNwYWNlc1xuXHRcdFx0bm90ZVRpdGxlID0gbm90ZVRpdGxlLnRyaW0oKTtcblx0XHRcdC8vIFJlbmFtZSB0aGUgbm90ZSBmaWxlIHdpdGggdGhlIG5ldyB0aXRsZVxuXHRcdFx0Y29uc3QgZmlsZVBhdGggPSBkaXIgKyAnLycgKyBub3RlVGl0bGUgKyAnLm1kJ1xuXHRcdFx0dGhpcy5hcHAuZmlsZU1hbmFnZXIucmVuYW1lRmlsZShub3RlLCBmaWxlUGF0aCk7XG5cdFx0fVxuXHR9XG5cblx0cHJpdmF0ZSByZW1vdmVFbW9qaXNGcm9tQWxsTm90ZXMoKSB7XG5cdFx0Ly8gR2V0IGFsbCB0aGUgbWFya2Rvd24gZmlsZXMgaW4gdGhlIHZhdWx0XG5cdFx0Y29uc3QgZmlsZXMgPSB0aGlzLmFwcC52YXVsdC5nZXRNYXJrZG93bkZpbGVzKCk7XG5cdFx0Ly8gTG9vcCB0aHJvdWdoIHRoZSBmaWxlc1xuXHRcdGZvciAoY29uc3QgZmlsZSBvZiBmaWxlcykge1xuXHRcdFx0Ly8gQ2FsbCB0aGUgcmVtb3ZlVGFnc0Vtb2ppRnJvbVRpdGxlIGZ1bmN0aW9uIG9uIGVhY2ggZmlsZVxuXHRcdFx0dGhpcy5yZW1vdmVUYWdzRW1vamlGcm9tVGl0bGUoZmlsZSk7XG5cdFx0fVxuXHR9XG5cbn1cblxuIl0sCiAgIm1hcHBpbmdzIjogIjs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7O0FBQUE7QUFBQTtBQUFBO0FBQUE7QUFBQTtBQUFBLHNCQUE0QjtBQUc1QixJQUFxQixnQkFBckIsY0FBMkMsdUJBQU87QUFBQSxFQUFsRDtBQUFBO0FBRUMsNEJBQW1CO0FBRW5CLDZCQUFvQjtBQUFBO0FBQUE7QUFBQSxFQUdwQixNQUFNLFNBQVM7QUFFZCxTQUFLO0FBQUEsTUFDSixLQUFLLElBQUksY0FBYyxHQUFHLFdBQVcsS0FBSyxvQkFBb0IsS0FBSyxJQUFJLENBQUM7QUFBQSxJQUN6RTtBQUdBLFNBQUssV0FBVztBQUFBLE1BQ2YsSUFBSTtBQUFBLE1BQ0osTUFBTTtBQUFBLE1BQ04sVUFBVSxNQUFNO0FBQ2YsYUFBSyxvQkFBb0I7QUFBQSxNQUMxQjtBQUFBLElBQ0QsQ0FBQztBQUVELFNBQUssV0FBVztBQUFBLE1BQ2YsSUFBSTtBQUFBLE1BQ0osTUFBTTtBQUFBLE1BQ04sVUFBVSxNQUFNO0FBQ2YsYUFBSyx5QkFBeUI7QUFBQSxNQUMvQjtBQUFBLElBQ0QsQ0FBQztBQUFBLEVBQ0Y7QUFBQSxFQUVRLG9CQUFvQixNQUFhO0FBbEMxQztBQXFDRSxVQUFNLE9BQU8sS0FBSyxJQUFJLGNBQWMsYUFBYSxJQUFJLEVBQUU7QUFDdkQsUUFBSSxLQUFLLFVBQVU7QUFBTTtBQUN6QixVQUFNLE1BQU0sS0FBSyxPQUFPO0FBRXhCLFVBQU0sWUFBWSxLQUFLO0FBRXZCLFFBQUksTUFBTTtBQUdULFVBQUksU0FBbUIsQ0FBQztBQUN4QixpQkFBVyxPQUFPLE1BQU07QUFFdkIsY0FBTSxVQUFVLElBQUk7QUFFcEIsWUFBSSxLQUFLLGlCQUFpQixLQUFLLE9BQU8sR0FBRztBQUV4QyxjQUFJLFlBQXNCLE1BQU0sTUFBSyxhQUFRLE1BQU0sS0FBSyxnQkFBZ0IsTUFBbkMsWUFBd0MsQ0FBQyxDQUFDO0FBQy9FLHNCQUFZLFVBQVUsT0FBTyxhQUFXLENBQUMsT0FBTyxTQUFTLE9BQU8sQ0FBQztBQUVqRSxtQkFBUyxDQUFDLEdBQUcsUUFBUSxHQUFHLFNBQVM7QUFBQSxRQUVsQztBQUFBLE1BQ0Q7QUFFQSxZQUFNLHdCQUF3QixVQUFVLFFBQVEsS0FBSyxtQkFBbUIsRUFBRTtBQUMxRSxVQUFJLE9BQU8sU0FBUyxHQUFHO0FBQ3RCLGNBQU0sZUFBYyxzQ0FBUSxLQUFLLFFBQWIsWUFBb0I7QUFDeEMsY0FBTSxlQUFlLGNBQWMsTUFBTTtBQUN6QyxjQUFNLFdBQVcsTUFBTSxNQUFNLGVBQWU7QUFDNUMsYUFBSyxJQUFJLFlBQVksV0FBVyxNQUFNLFFBQVE7QUFBQSxNQUMvQztBQUFBLElBRUQsT0FBTztBQUdOLFVBQUksZUFBZSxVQUFVLFFBQVEsS0FBSyxrQkFBa0IsRUFBRTtBQUU5RCxxQkFBZSxhQUFhLEtBQUs7QUFFakMsWUFBTSxXQUFXLE1BQU0sTUFBTSxlQUFlO0FBQzVDLFdBQUssSUFBSSxZQUFZLFdBQVcsTUFBTSxRQUFRO0FBQUEsSUFDL0M7QUFBQSxFQUNEO0FBQUEsRUFFUSxzQkFBc0I7QUFFN0IsVUFBTSxRQUFRLEtBQUssSUFBSSxNQUFNLGlCQUFpQjtBQUU5QyxlQUFXLFFBQVEsT0FBTztBQUV6QixXQUFLLG9CQUFvQixJQUFJO0FBQUEsSUFDOUI7QUFBQSxFQUNEO0FBQUEsRUFFUSx5QkFBeUIsTUFBYTtBQTNGL0M7QUFnR0UsVUFBTSxPQUFPLEtBQUssSUFBSSxjQUFjLGFBQWEsSUFBSSxFQUFFO0FBQ3ZELFFBQUksS0FBSyxVQUFVO0FBQU07QUFDekIsVUFBTSxNQUFNLEtBQUssT0FBTztBQUN4QixRQUFJLFlBQVksS0FBSztBQUVyQixRQUFJLE1BQU07QUFFVCxpQkFBVyxPQUFPLE1BQU07QUFFdkIsY0FBTSxVQUFVLElBQUk7QUFFcEIsWUFBSSxLQUFLLGlCQUFpQixLQUFLLE9BQU8sR0FBRztBQUV4QyxnQkFBTSxZQUFzQixNQUFNLE1BQUssYUFBUSxNQUFNLEtBQUssZ0JBQWdCLE1BQW5DLFlBQXdDLENBQUMsQ0FBQztBQUVqRixxQkFBVyxTQUFTLFdBQVc7QUFFOUIsd0JBQVksVUFBVSxRQUFRLE9BQU8sRUFBRTtBQUFBLFVBQ3hDO0FBQUEsUUFDRDtBQUFBLE1BQ0Q7QUFFQSxrQkFBWSxVQUFVLEtBQUs7QUFFM0IsWUFBTSxXQUFXLE1BQU0sTUFBTSxZQUFZO0FBQ3pDLFdBQUssSUFBSSxZQUFZLFdBQVcsTUFBTSxRQUFRO0FBQUEsSUFDL0M7QUFBQSxFQUNEO0FBQUEsRUFFUSwyQkFBMkI7QUFFbEMsVUFBTSxRQUFRLEtBQUssSUFBSSxNQUFNLGlCQUFpQjtBQUU5QyxlQUFXLFFBQVEsT0FBTztBQUV6QixXQUFLLHlCQUF5QixJQUFJO0FBQUEsSUFDbkM7QUFBQSxFQUNEO0FBRUQ7IiwKICAibmFtZXMiOiBbXQp9Cg==
