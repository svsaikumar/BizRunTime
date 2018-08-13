import { Component } from "@angular/core";
@Component({
    selector:'directive6',
    template:
    `
    <button (click) = "changeViewMode('map')">Map Mode</button>
    <button (click) = "changeViewMode('list')">List Mode</button>
    <button (click) = "changeViewMode('set')">Set Mode</button>
    <div [ngSwitch] ="viewMode">
        <div *ngSwitchCase="'map'">Map View Content</div>
        <div *ngSwitchCase="'list'">List View Content</div>
        <div *ngSwitchDefault>some default</div>
    </div>
    
    `
})

export class Directive6Component
{
    viewMode = "map";
    changeViewMode(mode)
    {
        this.viewMode = mode;
    }
}