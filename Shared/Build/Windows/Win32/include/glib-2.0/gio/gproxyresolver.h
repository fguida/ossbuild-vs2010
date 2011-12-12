/* GIO - GLib Input, Output and Streaming Library
 *
 * Copyright (C) 2010 Collabora, Ltd.
 *
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 2 of the License, or (at your option) any later version.
 *
 * This library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General
 * Public License along with this library; if not, write to the
 * Free Software Foundation, Inc., 59 Temple Place, Suite 330,
 * Boston, MA 02111-1307, USA.
 *
 * Author: Nicolas Dufresne <nicolas.dufresne@collabora.co.uk>
 */

#if !defined (__GIO_GIO_H_INSIDE__) && !defined (GIO_COMPILATION)
#error "Only <gio/gio.h> can be included directly."
#endif

#ifndef __G_PROXY_RESOLVER_H__
#define __G_PROXY_RESOLVER_H__

#include <gio/giotypes.h>

G_BEGIN_DECLS

#define G_TYPE_PROXY_RESOLVER         (g_proxy_resolver_get_type ())
#define G_PROXY_RESOLVER(o)           (G_TYPE_CHECK_INSTANCE_CAST ((o), G_TYPE_PROXY_RESOLVER, GProxyResolver))
#define G_IS_PROXY_RESOLVER(o)        (G_TYPE_CHECK_INSTANCE_TYPE ((o), G_TYPE_PROXY_RESOLVER))
#define G_PROXY_RESOLVER_GET_IFACE(o) (G_TYPE_INSTANCE_GET_INTERFACE ((o), G_TYPE_PROXY_RESOLVER, GProxyResolverInterface))

/**
 * G_PROXY_RESOLVER_EXTENSION_POINT_NAME:
 *
 * Extension point for proxy resolving functionality.
 * See <link linkend="extending-gio">Extending GIO</link>.
 */
#define G_PROXY_RESOLVER_EXTENSION_POINT_NAME "gio-proxy-resolver"

/**
 * GProxyResolver:
 *
 * Interface that can be used to resolve proxy address.
 */
typedef struct _GProxyResolverInterface GProxyResolverInterface;

struct _GProxyResolverInterface {
  GTypeInterface g_iface;

  /* Virtual Table */
  gboolean (* is_supported)  (GProxyResolver       *resolver);

  gchar	** (* lookup)        (GProxyResolver       *resolver,
			      const gchar          *uri,
			      GCancellable         *cancellable,
			      GError              **error);

  void     (* lookup_async)  (GProxyResolver       *resolver,
			      const gchar          *uri,
			      GCancellable         *cancellable,
			      GAsyncReadyCallback   callback,
			      gpointer              user_data);

  gchar	** (* lookup_finish) (GProxyResolver       *resolver,
			      GAsyncResult         *result,
			      GError              **error);
};

GType		g_proxy_resolver_get_type       (void) G_GNUC_CONST;
GProxyResolver *g_proxy_resolver_get_default    (void);

gboolean        g_proxy_resolver_is_supported   (GProxyResolver       *resolver);
gchar	      **g_proxy_resolver_lookup		(GProxyResolver       *resolver,
						 const gchar          *uri,
						 GCancellable         *cancellable,
						 GError              **error);
void		g_proxy_resolver_lookup_async   (GProxyResolver       *resolver,
						 const gchar          *uri,
						 GCancellable         *cancellable,
						 GAsyncReadyCallback   callback,
						 gpointer              user_data);
gchar	      **g_proxy_resolver_lookup_finish  (GProxyResolver       *resolver,
						 GAsyncResult         *result,
						 GError              **error);


G_END_DECLS

#endif /* __G_PROXY_RESOLVER_H__ */
