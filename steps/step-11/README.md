# CloudNativeApplicationsHandsOn-DevDaysEurope-2022

[Previous step](../step-10/README.md) - [Next step](../step-12/README.md)

## Step 11 - Finding the recource group that bundles all Kubernetes network resources

The web application is exposed inside the Kubernetes cluster, but not accessible from the outside world. For this to work, we will need to add some things to Kubernetes and Azure.

Azure has created a seperate resource group for all Kubernetes networking components. Use the following command to learn the name of this resource group:

```
az aks show --resource-group <your resource group> --name <your aks cluster> --query nodeResourceGroup -o tsv
```

```
az aks show --resource-group rg-involved-cafe-2020-07 --name aks-involved-cafe-2020-07 --query nodeResourceGroup -o tsv
```

For my case, it outputs the following resource group:

```
MC_rg-involved-cafe-2020-07_aks-involved-cafe-2020-07_westeurope
```

You can find the resource group and its resources inside the Azure Portal using the search feature:

![dotnet new](sshot-68.png)

[Previous step](../step-10/README.md) - [Next step](../step-12/README.md)