# CloudNativeApplicationsHandsOn-DevDaysEurope-2022

[Previous step](../step-11/README.md) - [Next step](../step-13/README.md)

## Step 12 - Adding an NGINX ingress controller

https://kubernetes.github.io/ingress-nginx/deploy/


kubectl apply -f https://raw.githubusercontent.com/kubernetes/ingress-nginx/controller-v1.2.0/deploy/static/provider/cloud/deploy.yaml


kubectl --namespace ingress-nginx get services -o wide

[Previous step](../step-11/README.md) - [Next step](../step-13/README.md)