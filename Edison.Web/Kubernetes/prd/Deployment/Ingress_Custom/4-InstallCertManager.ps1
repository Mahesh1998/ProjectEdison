helm install --name cert-manager stable/cert-manager --namespace kube-system --set ingressShim.defaultIssuerName=letsencrypt-prod --set ingressShim.defaultIssuerKind=ClusterIssuer --set rbac.create=true --set serviceAccount.create=true
#helm delete cert-manager --purge