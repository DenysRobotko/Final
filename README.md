# Final
For this solution was used Sitecore (v 9.0.1) and SXA module (v 1.8.1).<br>
For the site was used food site template. 3 pages were created (Home Page, Search Page and Error 404 page). Every page has same header and footer. The header gives possibility to go between pages.<br>
For the "Mini Article" item was used Simple Workflow.&nbsp;<br>
For the Error->Error, Mini Article->Title, Header->Title, Footer, Food Item-> Title fields were used validation rules.<br>
For the Header and Footer renderings were chosen cache options.<br>
Search was developed to find "Mini Article" items. Search was implemented using SOLR.<br>
Event for "item:saved" was modified to log some message.<br>
Processor "Siteresolver" was modified to log some message.<br>
For the project was used HELIX architecture.
