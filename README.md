# Final
For this solution was used Sitecore (v 9.0.1) and SXA module (v 1.8.1).
For the site was used food site template. 3 pages were created (Home Page, Search Page and Error 404 page). Every page has same header and footer. The header gives possibility to go between pages.
For the "Mini Article" item was used Simple Workflow.
For the Error->Error, Mini Article->Title, Header->Title, Footer, Food Item-> Title fields were used validation rules.
For the Header and Footer renderings were chosen cache options.
Search was developed to find "Mini Article" items. Search was implemented using SOLR.
Event for "item:saved" was modified to log some message.
Processor "Siteresolver" was modified to log some message.
For the project were used HELIX architecture.