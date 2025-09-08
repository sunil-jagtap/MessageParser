import { ChangeDetectorRef, Component } from '@angular/core';
import { BinParserService, ParsedMessage } from '../../services/bin-parser';
import { CommonModule, NgFor, NgIf } from '@angular/common';

@Component({
  selector: 'app-file-upload',
   imports: [CommonModule /* other modules/services */],
  templateUrl: './file-upload.html',
  styleUrls: ['./file-upload.css']
})
export class FileUploadComponent {
  selectedFile: File | null = null;
  messages: ParsedMessage[] = [];
  error = '';
  loading = false;

  constructor(private binParserService: BinParserService, private changeDetect: ChangeDetectorRef) {}

  onFileSelected(event: Event): void {
    this.error = '';
    const input = event.target as HTMLInputElement;
    if (!input.files?.length) return;
    const file = input.files[0];
    if (!file.name.toLowerCase().endsWith('.bin')) {
      this.error = 'Only .bin files are allowed';
      this.selectedFile = null;
      return;
    }
    this.selectedFile = file;
  }

  onUpload(): void {
    if (!this.selectedFile) {
      this.error = 'Please select a file first';
      return;
    }
    this.loading = true;
    this.messages = [];
    this.error = '';

    this.binParserService.uploadFile(this.selectedFile).subscribe({
      next: (res) => {
        this.messages = res;
        console.log('Parsed messages:', this.messages);
        this.loading = false;
      },
      error: (err) => {
        this.error = err.message;
        this.loading = false;
      },
      complete: () => { this.changeDetect.detectChanges(); }
    });
  }
}
