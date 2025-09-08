import { Routes } from '@angular/router';
import { FileUploadComponent } from './components/file-upload/file-upload';

export const routes: Routes = [
  { path: 'upload', component: FileUploadComponent },
  { path: '', redirectTo: 'upload', pathMatch: 'full' }
];